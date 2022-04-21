
// calling implicit and explicit implementations of Lose
Person p = new();
p.Lose(); // calls implicit implementation of losing a key
((IGamePlayer)p).Lose(); // calls explicit implementation of losing a game
IGamePlayer player = p as IGamePlayer;
player.Lose(); // calls explicit implementation of losing a game


