// See https://aka.ms/new-console-template for more information
using FacadePattern;

Console.WriteLine("Hello, World!");

CdPlayer cdPlayer = new CdPlayer();
DvdPlayer dvdPlayer = new DvdPlayer();
Screen screen = new Screen();
Projector projector = new Projector(dvdPlayer);
Tuner tuner = new Tuner() ;
Amplifier amplifier = new Amplifier(cdPlayer, dvdPlayer, tuner);


HomeTeatherFacade homeTeatherFacade = new HomeTeatherFacade(amplifier,cdPlayer,dvdPlayer,screen,projector,tuner);
homeTeatherFacade.WatchMovie();
homeTeatherFacade.EndMovie();