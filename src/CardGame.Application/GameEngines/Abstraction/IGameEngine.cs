using CardGame.Domain.Entities.Enums;

namespace CardGame.Application.GameEngines
{
    public interface IGameEngine
    {
        public string GameID { get; }
        public GameTypes GameType { get; }
    }
}
