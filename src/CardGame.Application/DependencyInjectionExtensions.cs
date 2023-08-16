using CardGame.Application.GameEngines;
using CardGame.Application.Shufflers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CardGame.Application
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddCardGame(this IServiceCollection services)
        {
            services.TryAddSingleton<IShuffler, Fisher_YatesShuffler>();
            services.TryAddSingleton<GameEngineFactory>();
            services.TryAddSingleton<GameCollection>();
            return services;
        }
    }
}
