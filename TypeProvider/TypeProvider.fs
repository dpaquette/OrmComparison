module FSharpTypeProviderExample

    open System.Data.Linq
    open FSharp.Data


    let db = Database.dbSchema.GetDataContext(System.Configuration.ConfigurationManager.ConnectionStrings.["connectionString"].ConnectionString)
    //db.DataContext.Log <- System.Console.Out
    
    

    let GetAll() = 
        let query = query { for row in db.Campaign do 
                            select row }
        query |> Seq.map(fun x -> Mappings.MapCampaign x) |> List.ofSeq

    let GetDbEntityById(id) =
         query { for row in db.Campaign do 
                        where (row.Id = id)
                        select row } |> Seq.head
    let GetById(id) = 
         GetDbEntityById(id) |> Mappings.MapCampaign 

    let UpdateCampaign(campaign:OrmComparison.Campaign) = 
        let dbEntity = GetDbEntityById(campaign.Id)
        let mapped = Mappings.MapCampaignBack(dbEntity, campaign)
        db.DataContext.SubmitChanges()

    let UpdateCampaign2(campaign:OrmComparison.Campaign) = 
        let updatecommand = new SqlCommandProvider<"""update campaign set name = @name, description=@description""", 
                                                    Database.buildTimeConnectionString>(System.Configuration.ConfigurationManager.ConnectionStrings.["connectionString"].ConnectionString)
        updatecommand.Execute(campaign.Name, campaign.Description)