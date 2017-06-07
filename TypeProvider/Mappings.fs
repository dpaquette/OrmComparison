module Mappings
    
    let MapCampaign(campaign: Database.dbSchema.ServiceTypes.Campaign) = 
            OrmComparison.Campaign( Id = campaign.Id, 
                                    Name = campaign.Name,
                                    Description  = campaign.Description,
                                    ExternalUrlText = campaign.ExternalUrlText,
                                    TimeZoneId = campaign.TimeZoneId
            )

    let MapCampaignBack(dbEntity: Database.dbSchema.ServiceTypes.Campaign, campaign: OrmComparison.Campaign) = 
        dbEntity.Id <- campaign.Id
        dbEntity.Name <- campaign.Name
        dbEntity.Description <- campaign.Description
        dbEntity.ExternalUrlText <- campaign.ExternalUrl
        dbEntity