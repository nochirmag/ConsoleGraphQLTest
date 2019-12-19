using GraphQL.Client;
using GraphQL.Common.Request;
using System;

namespace ConsoleGraphQLTest
{
    class Program
    {
        private const string StoreAddress = @"";
        static void Main(string[] args)
        {
            using (GraphQLClient client = new GraphQLClient(StoreAddress))
            {
                GraphQLRequest request = new GraphQLRequest
                {
                    Query = "query {getDistributorProduct(id: 107891) {id price stock ean}}"
                };
                var response = client.PostAsync(request);
                // tu trzeba Result łapać bo żadanie nie jest await'owany
                if (response.Result.Data != null)
                {
                    Console.WriteLine(response.Result.Data);
                }
                else
                {
                    Console.WriteLine("Błąd ");
                }
            }
            Console.WriteLine("Done. Press any key to exit..");
            Console.ReadLine();
        }
    }
}