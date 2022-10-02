using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Movie_Store_MVC.Models;

namespace Movie_Store_MVC.Controllers.Data

{
    public class AppDbInitializer
        {
            public static void Seed(IApplicationBuilder applicationBuilder)
            {
                using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                    context.Database.EnsureCreated();

                    
                    //Actors
                    if (!context.Actors.Any())
                    {
                        context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Shah Rukh Khan",
                            Age = 56,
                            IdPictureUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fw.notrecinema.com%2Fimages%2Fusercontent%2Fstar%2Fshah-rukh-khan-photo_170526_43139.jpg&imgrefurl=https%3A%2F%2Fen.notrecinema.com%2Fcommunaute%2Fstars%2Fstars.php3%3Fstaridx%3D17675&tbnid=C_DvV8kYYGFM3M&vet=12ahUKEwif6MC1m6j2AhVMy6QKHZYBBKgQMygWegUIARCEAg..i&docid=hUaRmqyrpo0f-M&w=618&h=927&q=shahrukh%20khan&hl=en-GB&ved=2ahUKEwif6MC1m6j2AhVMy6QKHZYBBKgQMygWegUIARCEAg"

                        },
                        new Actor()
                        {
                            FullName = "Kajol",
                            Age = 47,
                            IdPictureUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fm.media-amazon.com%2Fimages%2FM%2FMV5BMjIwMjQ5MTQ4N15BMl5BanBnXkFtZTgwOTIyMDU0OTE%40._V1_.jpg&imgrefurl=https%3A%2F%2Fwww.imdb.com%2Fname%2Fnm0004418%2F&tbnid=wWNzRtdVL-RLlM&vet=12ahUKEwinuMXCm6j2AhVwg_0HHdOpB34QMygCegUIARDeAQ..i&docid=BmUaG3Km8wmc0M&w=1453&h=2048&q=kajol&hl=en-GB&ved=2ahUKEwinuMXCm6j2AhVwg_0HHdOpB34QMygCegUIARDeAQ"
                        },
                        new Actor()
                        {
                            FullName = "Rani Mukerji",
                            Age = 43,
                            IdPictureUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2F6%2F62%2FRani.Mukerji.jpg&imgrefurl=https%3A%2F%2Fsv.wikipedia.org%2Fwiki%2FRani_Mukerji&tbnid=ezzYffVKujTtPM&vet=12ahUKEwi6l6rUm6j2AhUjoFwKHRoPADkQMygPegUIARD8AQ..i&docid=h-VFvfvfIYMZBM&w=390&h=442&q=rani%20mukerji&hl=en-GB&ved=2ahUKEwi6l6rUm6j2AhUjoFwKHRoPADkQMygPegUIARD8AQ"
                        },
                        new Actor()
                        {
                            FullName = "Amitabh Bachan",
                            Age = 79,
                            IdPictureUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2F9%2F9e%2FAmitabh_Bachchan_December_2013.png&imgrefurl=https%3A%2F%2Fsv.wikipedia.org%2Fwiki%2FAmitabh_Bachchan&tbnid=-lcUvkDiDiqhIM&vet=12ahUKEwjugYbjm6j2AhUL2eAKHcUmC2YQMygBegUIARDUAQ..i&docid=pHmNlwfcAWEuUM&w=751&h=1058&q=amitabh%20bachchan&hl=en-GB&ved=2ahUKEwjugYbjm6j2AhUL2eAKHcUmC2YQMygBegUIARDUAQ"
                        },
                        new Actor()
                        {
                            FullName = "Preity Zinta",
                            Age = 47,
                            IdPictureUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fm.media-amazon.com%2Fimages%2FM%2FMV5BNjM3NzY5ODkwNl5BMl5BanBnXkFtZTcwMDUwMDgxOA%40%40._V1_UY1200_CR129%2C0%2C630%2C1200_AL_.jpg&imgrefurl=https%3A%2F%2Fwww.imdb.com%2Fname%2Fnm0006689%2F&tbnid=uTZogCCyXj-uOM&vet=12ahUKEwiJzpucnKj2AhUEyyoKHXYmDN0QMygGegUIARDuAQ..i&docid=NAuyludFDQpt0M&w=630&h=1200&q=preity%20zinta&hl=en-GB&ved=2ahUKEwiJzpucnKj2AhUEyyoKHXYmDN0QMygGegUIARDuAQ"
                        }
                    });
                        context.SaveChanges();
                    }
                   
                    
                    //Movies
                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Title = "Chennai Express",
                            Year = DateTime.Now,
                            Description = "Rahul, a young man, sets out to immerse his late grandfather's ashes at Rameshwaram. However, when he helps Meena, a runaway bride, board a train, he has to face the ire of her criminal family.",
                            Price = 129,
                            MovieImageURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2F1%2F1b%2FChennai_Express.jpg&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FChennai_Express&tbnid=PH8uAQurXPtELM&vet=12ahUKEwiDiuD0mqj2AhWW0oUKHXWuDXUQMygBegUIARDfAQ..i&docid=1Qps2vIjtWX_lM&w=258&h=374&q=chennai%20express&hl=en-GB&ved=2ahUKEwiDiuD0mqj2AhWW0oUKHXWuDXUQMygBegUIARDfAQ",
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Title = "Kabhi Alvida Naa Kehna",
                            Year = DateTime.Now,
                            Description = "Dev and Maya, who face struggles in their respective marriages, become friends. They try to help each other salvage their relationships but end up falling in love instead.",
                            Price = 199,
                            MovieImageURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2F7%2F7d%2FKabhi_Alvida_Naa_Kehna.jpg&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FKabhi_Alvida_Naa_Kehna&tbnid=CsklJWC7OQV3UM&vet=12ahUKEwjqtqGrmqj2AhUS-xoKHX0cC7IQMygAegUIARDWAQ..i&docid=N9SCHWDOPc_pyM&w=220&h=350&q=kabhi%20alvida%20naa%20kehna&ved=2ahUKEwjqtqGrmqj2AhUS-xoKHX0cC7IQMygAegUIARDWAQ",
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Title = "Don",
                            Year = DateTime.Now,
                            Description = "Vijay, a lookalike of criminal kingpin Don, is hired by DCP D'Silva in order to find Don's secrets. But after D'Silva dies, Vijay struggles to reveal his real identity.",
                            Price = 99,
                            MovieImageURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fm.media-amazon.com%2Fimages%2FM%2FMV5BMzAyMWE0MjgtMDVjNS00ZDMyLWE4NjQtNWU2ZDgyYTlmMjdjXkEyXkFqcGdeQXVyNjQ2MjQ5NzM%40._V1_FMjpg_UX1000_.jpg&imgrefurl=https%3A%2F%2Fwww.imdb.com%2Ftitle%2Ftt0461936%2F&tbnid=2yUt3w98NCXMoM&vet=12ahUKEwjRpZ6Umqj2AhUDAsAKHb28CU4QMygBegUIARDgAQ..i&docid=RPKoaTM3E5PNPM&w=1000&h=1446&q=don&ved=2ahUKEwjRpZ6Umqj2AhUDAsAKHb28CU4QMygBegUIARDgAQ",
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Title = "Pink",
                            Year = DateTime.Now,
                            Description = "After being molested, Minal, along with her friends, tries to file an FIR against a politician's nephew. When the subsequent case gets rigged, Deepak, a retired lawyer, helps them to fight the case.",
                            Price = 179,
                            MovieImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Title = "Veer-Zaara",
                            Year = DateTime.Now,
                            Description = "Love blooms between an Indian pilot, Veer, and a Pakistani girl, Zaara. As Veer spends his years in a Pakistani prison, Zaara believes him to be dead and devotes her life to his village in India.",
                            Price = 149,
                            MovieImageURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.primevideo.com%2Fgp%2Fvideo%2Fdetail%2F0GQH574WM7822DSIO4R03JHWDH%2Fref%3Datv_nb_lcl_sv_SE%3FpersistLanguage%3D1%26ie%3DUTF8%26token%3Dg99J2CYVyJ%252B4S0DVtCewVJMHWz%252Fj0nRuFXGUyjD%252BTLvIAAAADAAAAABd1iXVcmF3AAAAABVX8CwXqz4nuL9RKX%252F%252F%252Fw%253D%253D%26language%3Dsv_SE&psig=AOvVaw2RvDCk1Yw95Hz_3fJShtr4&ust=1646336844286000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCJCJ-eiYqPYCFQAAAAAdAAAAABAD",
                            MovieCategory = MovieCategory.Love
                        },
                        new Movie()
                        {
                            Title = "Dilwale Dulhania La Jayenge",
                            Year = DateTime.Now,
                            Description = "Dilwale Dulhania La Jayenge is about teenagers who go on an excursion with their friends. What they do not know is that they will meet the love of their life, that will not be accepted by the family",
                            Price = 129,
                            MovieImageURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.imdb.com%2Ftitle%2Ftt0112870%2F&psig=AOvVaw2lzL4IgT4ltdVUxibxsGGV&ust=1646003425321000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCJjK8N6-nvYCFQAAAAAdAAAAABAD",
                            MovieCategory = MovieCategory.Love
                        }
                    });
                        context.SaveChanges();
                    }
                    //Actors & Movies
                    if (!context.Actors_Movies.Any())
                    {
                        context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 0,
                            MovieId = 0
                        },
                        new Actor_Movie()
                        {
                            ActorId = 0,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 1
                        },
                         new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 0,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 0,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 0,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 5
                        }
                       
                    });
                        context.SaveChanges();
                    }
                }

            }

           
                
            }
        }