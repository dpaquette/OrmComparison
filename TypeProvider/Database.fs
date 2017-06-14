module Database
    open FSharp.Data.TypeProviders
    [<Literal>]
    let buildTimeConnectionString = "Server=localhost;Database=AllReady;Integrated Security=true;MultipleActiveResultsets=true;"

    type dbSchema = SqlDataConnection<buildTimeConnectionString>
    