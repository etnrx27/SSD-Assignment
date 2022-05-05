using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SSD_Assignment.Data;

namespace SSD_Assignment.Models
{
    public static class BookSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SSD_AssignmentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SSD_AssignmentContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Percy Jackson And The Lightning Thief",
                        Author = "Rick Riordan",
                        Price = 12.99,
                        Genre = "Adventure",
                        Image = "images/PercyJacksonLightning.jpg",
                        Synopsis = "Percy Jackson is a good kid, but he can't seem to focus on his schoolwork or control his temper. And lately, being away at boarding school is only getting worse - Percy could have sworn his pre-algebra teacher turned into a monster and tried to kill him. When Percy's mom finds out, she knows it's time that he knew the truth about where he came from, and that he go to the one place he'll be safe. She sends Percy to Camp Half Blood, a summer camp for demigods (on Long Island), where he learns that the father he never knew is Poseidon, God of the Sea. Soon a mystery unfolds and together with his friends—one a satyr and the other the demigod daughter of Athena - Percy sets out on a quest across the United States to reach the gates of the Underworld (located in a recording studio in Hollywood) and prevent a catastrophic war between the gods."
                    },

                    new Book
                    {
                        Title = "Percy Jackson And The Sea of Monsters",
                        Author = "Rick Riordan",
                        Price = 12.99,
                        Genre = "Adventure",
                        Image = "images/PercyJacksonSea.jpg",
                        Synopsis = "YOU CAN'T TELL BY LOOKING AT ME THAT MY DAD IS POSEIDON, GOD OF THE SEA.  It's not easy being a half-blood these days. Even a simple game of dodgeball becomes a death match against an ugly gang of cannibal giants - and that was only the beginning.  Now Camp Half-Blood is under attack and, unless I can get my hands of the Golden Fleece, the whole camp will be invaded by monsters. Big ones... "
                    },

                    new Book
                    {
                        Title = "Percy Jackson And The Titan's Curse",
                        Author = "Rick Riordan",
                        Price = 12.99,
                        Genre = "Adventure",
                        Image = "images/PercyJacksonTitan.jpg",
                        Synopsis = "IT'S NOT EVERYDAY YOU FIND YOURSELF IN COMBAT WITH A HALF-LION, HALF-HUMAN.  But when you're the son of a Greek god, it happens. And now my friend Annabeth is missing, a goddess is in chains and only five half-blood heroes can join the quest to defeat the doomsday monster.  Oh, and guess what? The Oracle has predicted that not all of us will survive...  "
                    },

                    new Book
                    {
                        Title = "Percy Jackson And The Battle of The Labyrinth",
                        Author = "Rick Riordan",
                        Price = 12.99,
                        Genre = "Adventure",
                        Image = "images/PercyJacksonBattle.jpg",
                        Synopsis = "HONESTLY, BLOWING UP ANOTHER SCHOOL WAS THE LAST THING I WANTED TO DO.  As the son of a Greek god, I've had my share of near-death disaster - and now my arch enemy Luke wants to invade our camp via an ancient Labyrinth.  If he succeeds, thousands of bloodthirsty monsters will attack. So it's goodbye sunshine, hello darkness as four of us descend into the terrifying underground and beyond...  "
                    },

                    new Book
                    {
                        Title = "Percy Jackson And The Last Olympian",
                        Author = "Rick Riordan",
                        Price = 12.99,
                        Genre = "Adventure",
                        Image = "images/PercyJacksonLast.jpg",
                        Synopsis = "MOST PEOPLE GET PRESENTS ON THEIR SIXTEENTH BIRTHDAY, I GET A PROPHECY THAT COULD SAVE OR DESTROY THE WORLD.  It happens when you're the son of Poseidon, God of the Sea. According to an ancient prophecy, I turn sixteen and the fate of the entire world is on me. But no pressure.  Now Kronos, Lord of the Titans, is beginning his attack on New York City. And the dreaded monster Typhon is also heading our way. So it's me and forty of my demigod friends versus untold evil..."
                    },

                    new Book
                    {
                        Title = "The Singapore Story",
                        Author = "Lee Kuan Yew",
                        Price = 24.99,
                        Genre = "Fiction",
                        Image = "images/TheSingaporeStory.jpg",
                        Synopsis = "Visionary? Authoritarian? Model for the West? Lee Kuan Yew, the long-time leader of Singapore, has been called all these things, and more. In these vivid memoirs, Lee takes a profoundly personal look back at the events that led to Singapore's independence and shaped its struggle for success. And, as always, he lets the chips fall where they may.In intimate detail, Lee recounts Singapore's unforgettable history.  You'll be with Lee as he leads striking unionists against the colonial government; shares tea and rounds of golf with key players in Britain and Malaya; and drinks warm Anchor beer with leaders of the communist underground at secret midnight meetings.  From British colonial rule through Japanese occupation in World War II, Communist insurrection, riots, independence -- and the struggles that followed -- few political memoirs anywhere have been this blunt, or this fascinating.Anyone interested in the political history of Singapore, Asia, and the modern world.   "
                    },

                    new Book
                    {
                        Title = "An Orphan's War",
                        Author = "Molly Green",
                        Price = 10.99,
                        Genre = "Fiction",
                        Image = "images/AnOrphanStory.jpg",
                        Synopsis = "War rages, but the women and children of Liverpool’s Dr Barnardo’s Home cannot give up hope. An Orphan’s War is a gripping saga about love and loss on the Home Front.    LIVERPOOL, 1940 When her childhood sweetheart Johnny is killed in action, Maxine Grey loses more than her husband – she loses her best friend. Desperate to make a difference in this awful war, Maxine takes a nursing job at London’s St Thomas’s Hospital.   A BROKEN HEART Maxine takes comfort in the attentions of a handsome surgeon, but Edwin Blake might not be all he seems. And as the Blitz descends on the capital, Maxine returns to Liverpool heartbroken and surrounded by the threat of scandal.   A BRAVE SPIRIT When offered a job at a Dr Barnardo’s orphanage, Maxine hopes this is the second chance she has been looking for. And one little boy in particular helps her to realise that she needs the orphans just as much as they need her…   A gripping story of love, friendship and hope in the darkest of places. Molly Green is an exciting new voice in saga fiction, perfect for fans of Nadine Dorries and Katie Flynn."
                    },

                    new Book
                    {
                        Title = "The Constitution of Knowledge: A Defense of Truth",
                        Author = "Jonathan Rauch",
                        Price = 13.99,
                        Genre = "Science",
                        Image = "images/TheConstitutionOfKnowledge.jpg",
                        Synopsis = "Arming Americans to defend the truth from today's war on facts  'In what could be the timeliest book of the year,Rauch aims to arm his readers to engage with reason in an age of illiberalism.' --Newsweek  Disinformation. Trolling. Conspiracies. Social media pile-ons. Campus intolerance. On the surface, these recent additions to our daily vocabulary appear to have little in common. But together, they are driving an epistemic crisis: a multi-front challenge to America's ability to distinguish fact from fiction and elevate truth above falsehood.  In 2016 Russian trolls and bots nearly drowned the truth in a flood of fake news and conspiracy theories, and Donald Trump and his troll armies continued to do the same. Social media companies struggled to keep up with a flood of falsehoods, and too often didn't even seem to try. Experts and some public officials began wondering if society was losing its grip on truth itself. Meanwhile, another new phenomenon appeared: 'cancel culture.' At the push of a button, those armed with a cellphone could gang up by the thousands on anyone who ran afoul of their sanctimony.  In this pathbreaking book, Jonathan Rauch reaches back to the parallel eighteenth-century developments of liberal democracy and science to explain what he calls the 'Constitution of Knowledge'--our social system for turning disagreement into truth.  By explicating the Constitution of Knowledge and probing the war on reality, Rauch arms defenders of truth with a clearer understanding of what they must protect, why they must do--and how they can do it. His book is a sweeping and readable description of how every American can help defend objective truth and free inquiry from threats as far away as Russia and as close as the cellphone. "
                    },

                    new Book
                    {
                        Title = "To Sir, with Love",
                        Author = "Lauren Layne",
                        Price = 9.99,
                        Genre = "Romance",
                        Image = "images/ToSirWithLove.jpg",
                        Synopsis = "Love Is Blind meets You’ve Got Mail in this laugh-out-loud romantic comedy following two thirty-somethings who meet on a blind dating app—only to realize that their online chemistry is nothing compared to their offline rivalry.  Perpetually cheerful and eager to please, Gracie Cooper strives to make the best out of every situation. So when her father dies just months after a lung cancer diagnosis, she sets aside her dreams of pursuing her passion for art to take over his Midtown Manhattan champagne shop. She soon finds out that the store’s profit margins are being squeezed perilously tight, and complicating matters further, a giant corporation headed by the impossibly handsome, but irritatingly arrogant Sebastian Andrews is proposing a buyout. But Gracie can’t bear the thought of throwing away her father’s dream like she did her own.  Overwhelmed and not wanting to admit to her friends or family that she’s having second thoughts about the shop, Gracie seeks advice and solace from someone she’s never met—the faceless “Sir”, with whom she connected on a blind dating app where matches get to know each other through messages and common interests before exchanging real names or photos.  But although Gracie finds herself slowly falling for Sir online, she has no idea she’s already met him in real life…and they can’t stand each other.   "
                    },

                    new Book
                    {
                        Title = "Ace Of Spades",
                        Author = "Faridah Abike-lyimide",
                        Price = 13.99,
                        Genre = "Thriller",
                        Image = "images/AceOfSpades.jpg",
                        Synopsis = "An incendiary and utterly compelling thriller with a shocking twist that delves deep into the heart of institutionalized racism, from an exceptional new YA voice.  Welcome to Niveus Private Academy, where money paves the hallways, and the students are never less than perfect. Until now. Because anonymous texter, Aces, is bringing two students' dark secrets to light.  Talented musician Devon buries himself in rehearsals, but he can't escape the spotlight when his private photos go public. Head girl Chiamaka isn't afraid to get what she wants, but soon everyone will know the price she has paid for power.  Someone is out to get them both. Someone who holds all the aces. And they're planning much more than a high-school game..."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
