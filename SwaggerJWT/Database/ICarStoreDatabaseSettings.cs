﻿namespace SwaggerJWT.Database
{
    public interface ICarStoreDatabaseSettings
    {
        string CarsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
