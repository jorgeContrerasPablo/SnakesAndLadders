using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Serilog;
using ServiceLayer;
using ServiceLayer.IService;
using System;
using System.IO;

namespace SnakesAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var host = AppStartup();

                var service = ActivatorUtilities.CreateInstance<GameService>(host.Services);

                string[] commands = new string[2];

                Console.WriteLine("Write exit to finish the game.");

                Console.WriteLine("Set number of players to play.");
                commands = Console.ReadLine().Split(" ");
                service.StartGame(Int32.Parse(commands[0]));
                // format exception
                while (commands[0] != "exit")
                {
                    try
                    {
                        Console.WriteLine("Set number of player to roll dice.");
                        commands = Console.ReadLine().Split(" ");
                        int playerNumber = Int32.Parse(commands[0]);
                        int spacesToMove = service.DiceRoll(playerNumber);
                        Console.WriteLine($"Player { playerNumber} moves {spacesToMove} spaces.");
                        int finalPositionPlayer = service.MovePlayerToken(spacesToMove, playerNumber);
                        Console.WriteLine($"Player { playerNumber} moves to {finalPositionPlayer}.");
                        if (finalPositionPlayer == service.GetFinalPosition())
                        {
                            Console.WriteLine($"Player {playerNumber}, Won!!");
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Please insert a correct format command");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Exception: {exception.Message}");
            }
        }

        static void BuildConfig(IConfigurationBuilder builder)
        {
            // Check the current directory that the application is running on 
            // Then once the file 'appsetting.json' is found, we are adding it.
            // We add env variables, which can override the configs in appsettings.json
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
        }

        static IHost AppStartup()
        {
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);

            // Specifying the configuration for serilog
            Log.Logger = new LoggerConfiguration() // initiate the logger configuration
                            .ReadFrom.Configuration(builder.Build()) // connect serilog to our configuration folder
                            .Enrich.FromLogContext() //Adds more information to our logs from built in Serilog 
                            .WriteTo.Console() // decide where the logs are going to be shown
                            .CreateLogger(); //initialise the logger

            Log.Logger.Information("Application Starting");

            var host = Host.CreateDefaultBuilder() // Initialising the Host 
                        .ConfigureServices((context, services) => { // Adding the DI container for configuration

                })
                        .UseSerilog() // Add Serilog
                        .Build(); // Build the Host

            return host;
        }
    }
}
