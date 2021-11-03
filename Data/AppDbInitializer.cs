using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Test_App.Models.Data
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {

            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationContext>();
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="Cinema1",
                            Logo="http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description="This is the discription of the first cinema"
                        },
                        new Cinema()
                        {
                            Name="Cinema2",
                            Logo="http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description="This is the discription of the second cinema"
                        },
                        new Cinema()
                        {
                            Name="Cinema3",
                            Logo="http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description="This is the discription of the thirteen cinema"
                        },
                        new Cinema()
                        {
                            Name="Cinema4",
                            Logo="http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description="This is the discription of the fourteen cinema"
                        },
                        new Cinema()
                        {
                            Name="Cinema5",
                            Logo="http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description="This is the discription of the fifteen cinema"
                        },
                        new Cinema()
                        {
                            Name="Cinema6",
                            Logo="http://dotnethow.net/images/cinemas/cinema-6.jpeg",
                            Description="This is the discription of the sixteen cinema"
                        },


                    });

                    context.SaveChanges();
                }
                //Actors

                if (!context.Actors.Any())
                {

                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor(){FullName="Actor1",ProfilePictureURL="http://dotnethow.net/images/actors/actor-1.jpeg",Bio="Bio of the actor 1"},
                        new Actor(){FullName="Actor2",ProfilePictureURL="http://dotnethow.net/images/actors/actor-2.jpeg",Bio="Bio of the actor 2"},
                        new Actor(){FullName="Actor3",ProfilePictureURL="http://dotnethow.net/images/actors/actor-3.jpeg",Bio="Bio of the actor 3"},
                        new Actor(){FullName="Actor4",ProfilePictureURL="http://dotnethow.net/images/actors/actor-4.jpeg",Bio="Bio of the actor 4"},
                        new Actor(){FullName="Actor5",ProfilePictureURL="http://dotnethow.net/images/actors/actor-5.jpeg",Bio="Bio of the actor 5"}
                    });

                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer(){FullName="Producer1",ProfilePictureURL="http://dotnethow.net/images/producers/producer-1.jpeg",Bio="Bio of the producer 1"},
                        new Producer(){FullName="Producer2",ProfilePictureURL="http://dotnethow.net/images/producers/producer-2.jpeg",Bio="Bio of the producer 2"},
                        new Producer(){FullName="Producer3",ProfilePictureURL="http://dotnethow.net/images/producers/producer-3.jpeg",Bio="Bio of the producer 3"},
                        new Producer(){FullName="Producer4",ProfilePictureURL="http://dotnethow.net/images/producers/producer-4.jpeg",Bio="Bio of the producer 4"},
                        new Producer(){FullName="Producer5",ProfilePictureURL="http://dotnethow.net/images/producers/producer-5.jpeg",Bio="Bio of the producer 5"}
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie(){
                        Name="Movie1",
                        Description="Description of movie 1",
                        Price=23.50,
                        ImageURL="http://dotnethow.net/images/movies/movie-1.jpeg",
                        StartDate=DateTime.Now.AddDays(-25),
                        EndDate=DateTime.Now.AddMonths(2),
                        MovieCategory=MovieCategory.Action,
                        CinemaId=1,
                        ProducerId=1
                        },
                        new Movie(){
                        Name="Movie2",
                        Description="Description of movie 2",
                        Price=33.50,
                        ImageURL="http://dotnethow.net/images/movies/movie-2.jpeg",
                        StartDate=DateTime.Now.AddDays(-2),
                        EndDate=DateTime.Now.AddMonths(1),
                        MovieCategory=MovieCategory.Comedy,
                        CinemaId=2,
                        ProducerId=2
                        },
                        new Movie(){
                        Name="Movie3",
                        Description="Description of movie 3",
                        Price=45.50,
                        ImageURL="http://dotnethow.net/images/movies/movie-3.jpeg",
                        StartDate=DateTime.Now.AddDays(-60),
                        EndDate=DateTime.Now.AddMonths(4),
                        MovieCategory=MovieCategory.documentary,
                        CinemaId=1,
                        ProducerId=1
                        },
                        new Movie(){
                        Name="Movie4",
                        Description="Description of movie 4",
                        Price=13.50,
                        ImageURL="http://dotnethow.net/images/movies/movie-4.jpeg",
                        StartDate=DateTime.Now.AddDays(-50),
                        EndDate=DateTime.Now.AddMonths(6),
                        MovieCategory=MovieCategory.Drama,
                        CinemaId=4,
                        ProducerId=4
                        },
                         new Movie(){
                        Name="Movie5",
                        Description="Description of movie 5",
                        Price=13.50,
                        ImageURL="http://dotnethow.net/images/movies/movie-5.jpeg",
                        StartDate=DateTime.Now.AddDays(-50),
                        EndDate=DateTime.Now.AddMonths(6),
                        MovieCategory=MovieCategory.Drama,
                        CinemaId=3,
                        ProducerId=4
                        },
                          new Movie(){
                        Name="Movie6",
                        Description="Description of movie 6",
                        Price=13.50,
                        ImageURL="http://dotnethow.net/images/movies/movie-6.jpeg",
                        StartDate=DateTime.Now.AddDays(-50),
                        EndDate=DateTime.Now.AddMonths(6),
                        MovieCategory=MovieCategory.Horor,
                        CinemaId=6,
                        ProducerId=5
                        },
                           new Movie(){
                        Name="Movie7",
                        Description="Description of movie 7",
                        Price=13.50,
                        ImageURL="http://dotnethow.net/images/movies/movie-7.jpeg",
                        StartDate=DateTime.Now.AddDays(-50),
                        EndDate=DateTime.Now.AddMonths(6),
                        MovieCategory=MovieCategory.Nationality,
                        CinemaId=3,
                        ProducerId=4
                        }

                    });

                    context.SaveChanges();
                }
                //Actors& Movies
                if (!context.Actor_Movies.Any())
                {
                    context.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie(){ActorId=1,MovieId=2},
                        new Actor_Movie(){ActorId=2,MovieId=2},
                        new Actor_Movie(){ActorId=2,MovieId=3},
                        new Actor_Movie(){ActorId=3,MovieId=4},
                        new Actor_Movie(){ActorId=4,MovieId=5},
                        new Actor_Movie(){ActorId=5,MovieId=5},
                        new Actor_Movie(){ActorId=5,MovieId=6},
                        new Actor_Movie(){ActorId=4,MovieId=7},
                        new Actor_Movie(){ActorId=3,MovieId=7},
                        new Actor_Movie(){ActorId=1,MovieId=1}
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
