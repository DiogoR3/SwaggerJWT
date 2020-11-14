namespace SwaggerJWT.Database
{
    public class CarStoreDatabaseSettings : ICarStoreDatabaseSettings
    {
        public string CarsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
