using System;
using System.Collections.ObjectModel;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.Framework.Common;

namespace TfsUtlities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application: TFS Console App Running..");

            // Connect to Team Foundation Server
            //     Server is the name of the server that is running the application tier for Team Foundation.
            //     Port is the port that Team Foundation uses. The default port is 8080.
            //     VDir is the virtual path to the Team Foundation application. The default path is tfs.
            Uri tfsUri = (args.Length < 1) ?
                new Uri("https://costaivo.visualstudio.com/") : new Uri(args[0]);

            TfsConfigurationServer configurationServer =
                TfsConfigurationServerFactory.GetConfigurationServer(tfsUri);

            // Get the catalog of team project collections
            ReadOnlyCollection<CatalogNode> collectionNodes = configurationServer.CatalogNode.QueryChildren(
                new[] { CatalogResourceTypes.ProjectCollection },
                false, CatalogQueryOptions.None);

            // List the team project collections
            foreach (CatalogNode collectionNode in collectionNodes)
            {
                // Use the InstanceId property to get the team project collection
                Guid collectionId = new Guid(collectionNode.Resource.Properties["InstanceId"]);
                TfsTeamProjectCollection teamProjectCollection = configurationServer.GetTeamProjectCollection(collectionId);

                // Print the name of the team project collection
                Console.WriteLine("Collection: " + teamProjectCollection.Name);

                // Get a catalog of team projects for the collection
                ReadOnlyCollection<CatalogNode> projectNodes = collectionNode.QueryChildren(
                    new[] { CatalogResourceTypes.TeamProject },
                    false, CatalogQueryOptions.None);

                // List the team projects in the collection
                foreach (CatalogNode projectNode in projectNodes)
                {
                    Console.WriteLine(" Team Project: " + projectNode.Resource.DisplayName);
                }
            }

            Console.WriteLine("Press Any Key to Exit");
            Console.ReadLine();
        }
    }
}

/*
 https://adamprescott.net/2009/12/22/link-tfs-work-items-programmatically/
 https://social.msdn.microsoft.com/Forums/vstudio/en-US/6c3deb80-cbb4-4b00-afdb-dca6cfb63087/create-onetomany-work-item-links-programmatically-in-tfs-2013?forum=tfsworkitemtracking
 https://programmaticponderings.wordpress.com/2012/04/15/automating-task-creation-in-team-foundation-server-with-powershell/
     */
