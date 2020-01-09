using PlayChess.Common;
using PlayChess.Engine.Contracts;
using PlayChess.Engine.Initializations;
using PlayChess.Inputs.Contracts;
using PlayChess.Players.Contracts;
using PlayChess.Renderers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;


namespace PlayChess.Engine
{
    using PlayChess.Board;
    using PlayChess.Board.Contracts;
    using PlayChess.Players;

    public class TwoPlayerEngine : IEngine
    {
        private readonly IEnumerable<IPlayer> players;
        private readonly IRenderer renderer;
        private readonly IInputProvider input;
        private readonly IBoard board;


        public TwoPlayerEngine(IRenderer renderer, IInputProvider inputProvider)
        {
            this.renderer = renderer;
            input = inputProvider;
            board = new Board();
        }

        public IEnumerable<IPlayer> Players
        {
            get
            {
                return new List<IPlayer>(this.players);
            }
        }

        public void Initialize(IGameInitialization gameInitialization)
        {
            //TODO: use the input for players

            var players = new List<IPlayer>
            {
                new Player("Pesho",GameColor.Black),
                new Player("Gosho",GameColor.White)
            };//input.GetPlayers(Constants.StandartGameNumberOfPlayers);
            
            gameInitialization.Initialize(players, this.board); //инициализираме дъксата и играчите

            renderer.RenderBoard(board);

        }

       

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void WinningConditions()
        {
            throw new NotImplementedException();
        }
    }
}
