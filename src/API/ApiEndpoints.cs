namespace API;

public static class ApiEndpoints
{
    private const string ApiBase = "api";

    public static class Products
    {
        private const string Base = $"{ApiBase}/products";

        public const string GetAll = Base;
        public const string Get = $"{Base}/{{productId:int}}";

        public const string GetBrands = $"{Base}/brands";
        public const string GetTypes = $"{Base}/types";
    }

}
