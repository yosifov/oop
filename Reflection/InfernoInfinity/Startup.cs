namespace OOP.Reflection.InfernoInfinity
{
    using System;
    using Microsoft.Extensions.DependencyInjection;
    using OOP.Reflection.InfernoInfinity.Contracts;
    using OOP.Reflection.InfernoInfinity.Core;
    using OOP.Reflection.InfernoInfinity.Core.Factories;
    using OOP.Reflection.InfernoInfinity.Data;

    public class Startup : IService
    {
        public void Execute()
        {
            IServiceProvider serviceProvider = ConfigureServices();            
            var engine = new Engine(serviceProvider);
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IWeaponFactory, WeaponFactory>();
            serviceCollection.AddTransient<IGemFactory, GemFactory>();
            serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();

            serviceCollection.AddSingleton<IWeaponRepository, WeaponRepository>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
