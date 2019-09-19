using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_aventure_des_chapeau_de_paille
{
    class Program
    {
        static void Main(string[] args) 
        {

            Console.WriteLine("Luffy et zoro sont de très bon amis de dans l'équipage au chapeau de paille, mais les deux amis cherchent à faire une compétition amicale pour trouver le one piece le premier.luffy et zoro cherchent un consseiller pour leur aventure. quel personnage voulez vous accompagner ? écrivez '1' pour acompagner luffy et écrivez '2' pour acompagner zoro");
            int conseil = 0;
            int adversaire = 0;
            int personnage = 0;
            personnage = Convert.ToInt32(Console.ReadLine());

            if (personnage == 1)
            {
                Console.WriteLine("vous avez choisis luffy. luffy apercois un bateau de pirate au loin. il voit l'emblème de l'équipage de doflamingoh sur les voiles. si vous croyer que luffy devrait aller l'affronté appuyer sur '1' et si vous croyez qu'il devrait éviter le combat appuyer sur '2' ");
                adversaire = Convert.ToInt32(Console.ReadLine());
                if (adversaire == 1)
                {
                    Console.WriteLine("bonne decision, c'est en se battant qu'on devient plus fort . malgrè le fait que doflamingoh sois puissant luffy a réussis  a le mettre k.o");

                    Console.WriteLine("luffy se trouve devant un autres obstacle , il voit un gigantesque morceau de viande appétissant.appuyer sur '1'pour lui dire de le manger ou si vous preférer qu'il continue l'aventure appuyer sur '2'");
                    conseil = Convert.ToInt32(Console.ReadLine());

                    if (conseil == 1)
                    {
                        Console.WriteLine("luffy a trop manger il est trop lourd pour embarquer sur le bateau");

                    }
                      if (conseil == 2)
                      {
                        Console.WriteLine("luffy continue son chemin et retourne sur son bateau pour continuer a essayer de trouver le one piece malgrès la faim . quelque temp plus tard, il retrouvesur son chemin l'empereur kaido au cent bêtes. luffy veux savoir ce qu'il dois faire ! appuyez sur '1'si vous voulez lui consseiller de se battre contre lui ou appuyer sur '2' si vous voulez lui consseiller de contourner kaido ");

                        int combat = 0;

                        combat = Convert.ToInt32(Console.ReadLine());
                        if (combat == 2)
                        {
                            Console.WriteLine("en contournent kaido le bateau tombe tombe dans un tourbillon infinie. il est impossible de sortir du tourbillons .l'Aventure se termine ici");
                        }
                        if (combat == 1)
                        {
                            Console.WriteLine("luffy se bat contre kaido ...");

                            int chance = 0;



                            Random generateur = new Random();
                            chance = (int)generateur.Next(1, 3);

                            if (chance == 1)
                            {
                                Console.WriteLine("malchance, kaido était trop fort pour luffy");
                            }

                            if (chance == 2)
                            {
                                Console.WriteLine("luffy a gagner malgrè la puissance phénoménale de kaido. il poursuis donc sa route. luffy appercois au loin deux iles.une ile volcanique et une ile qu'on prenome raftel. appuyer sur '1' pour aller a l'ile volcanique et appuyer sur '2' pour aller a raftel ");

                                int destination = 0;

                                destination = Convert.ToInt32(Console.ReadLine());

                                if (destination == 2)
                                {
                                    Console.WriteLine("luffy arrive a raftel et trouve sur la plage deux objet scintillant . un ressemble a une petite statue et l'autre a une boite en argent. si vous croyer qu'il devrais choisis la statue appuyer sur '1', si vous croyez qu'il devrait ouvrir la boite appuyer sur '2'");

                                    int trésor = 0;

                                    trésor = Convert.ToInt32(Console.ReadLine());

                                    if (trésor == 1)
                                    {
                                        Console.WriteLine("luffy prend la statue et se demende a quoi elle pourrait bien servir. il la secout vivement et celle-ci se brise en deux.Une clée tombe de la statuette. luffy se demende a quoi pourait servir cette clé. appuyer sur '1' si vous croyez qu'il devrait chercher sur l'ile si il n'y aurait pas une serrure apartenant a cette clef ou appuyer sur '2' si vous croyer qu'il devrait abandonner la clé et se concentrer sur la boite argentée");

                                        int choix = 0;

                                        choix = Convert.ToInt32(Console.ReadLine());

                                        if (choix == 1)
                                        {
                                            Console.WriteLine(" vous avez pris la bonne decision puisque luffy trouve une paire de double porte incruster sur une montagne fermer a clé et en inserrent la clé les porte s'ouvre. a l'interieur se trouve des tonnes de pièces d'or. un papier est sur le dessus de l'amas de piece d'or. l'écriture dit ceci 'bien jouer cher aventurier vous etes parvenu a trouver mon trésor,le One piece -Gold.D.Roger");
                                            Console.WriteLine("vous avez réussis a aider luffy a trouver le trésor BIEN JOUER !!!");
                                        }
                                        if (choix == 2)
                                        {
                                            Console.WriteLine("luffy ouvre la boite et un papier s'y trouve a l'interrieur , on peux constater sur le papier qu'il y est ecrit ''trop tard j'ai trouver le contune de la boite avant toi ''. Luffy désesperer retourne sur son bateau et repart retrouver ses amis");
                                        }

                                    }
                                    if (trésor == 2)
                                    {
                                        Console.WriteLine("luffy ouvre la boite et un papier s'y trouve a l'interrieur , on peux constater sur le papier qu'il y est ecrit ''trop tard j'ai trouver le contune de la boite avant toi ''. Luffy désesperer retourne sur son bateau et repart retrouver ses amis");
                                    }




                                }
                                if (destination == 1)
                                {
                                    Console.WriteLine("luffy curieux de ce qu'il pourait se trouver sur l'ile volcanique s'en aproche. aussitot qu'il atteind la plage d'obcidienne les voile du bateau prenne feu. luffy compris par la suite que son aventure se terminerais là");
                                }

                            }
                        

                      }

                    }

                }
            }
            if (adversaire == 2)
            {
                Console.WriteLine("vous sous estimez la puissance de luffy , vous n'etes pas digne d'etre son consseiller ");
            }

            if (personnage == 2)
            {
                Console.WriteLine("vous avez choisis zoro.le bras droit de l'équipage se retrouve devant une question métant son orgueuil en jeux. il se demende si il devrait suivre la carte au trésor qu'il a trouver fait par Gold.D.Roger l'ancien détanteur du one piece ou suivre son instinct. appuyer sur '1' pour qu'il suis la carte ou appuyer sur '2' si vous penssez qu'il devrait suivre son instinct");

                int carte = 0;

                carte = Convert.ToInt32(Console.ReadLine());
                if (carte == 2)
                {
                    Console.WriteLine("zoro a un tres mauvais instinct lorsqu'il sagis de trouver sa route. de ce fait zoro se perd comme a l'habitude");
                }
                if (carte == 1)
                {
                    Console.WriteLine("vous connaissez bien zoro , vous savez que s'il suis son instinct il sera perdu a coup sur. mais, malheureusement la carte de zoro la mener sur le chemin de mihawk , le meilleur épéiste au monde. appuyer sur '1'si vous croyer qu'il devrait se battre contre lui ou appuyer sur '2' si vous croyez qu'il devrait prendre la fuite");
                    int combat = 0;

                    combat = Convert.ToInt32(Console.ReadLine());
                    if (combat == 2)
                    {
                        Console.WriteLine("zoro réussis a s'enfuire de mihawk. mais le problème est que .... il c'est perdu.");
                    }
                    if (combat == 1)
                    {
                        Console.WriteLine("zoro se bat contre mihawk...");

                        int chance = 0;


                        Random generateur = new Random();
                        chance = (int)generateur.Next(1, 3);

                        if (chance == 2)
                        {
                            Console.WriteLine("malchance il était trop tot pour que zoro affronte mihawk.Zoro se résigne a retourner a l'entrainement avant de retenter sa chance ");

                        }
                        if (chance == 1)
                        {
                            Console.WriteLine("apres un combat acharner zoro .il réussis a atteindre mihawk avec un coup bien placer le metant K.O. zoro peut donc continuer sa route. zoro apercois deux iles , l'iles labyrinthe et raftel. appuyer sur '1' si vous croyez que zoro devrait se rendre sur l'ile labyrinthe ou appuyer sur '2' si vous croyez qu'il devrait se rendre sur raftel");

                            int ile = 0;

                            ile = Convert.ToInt32(Console.ReadLine());

                            if (ile == 1)
                            {
                                Console.WriteLine("zoro se retrouve devend son plus grand adversaire ,un labyrinthe . zoro se perd dans celui-ci metant fin a son aventure.");
                            }
                            if (ile == 2)
                            {
                                Console.WriteLine("zoro se dirige vers raftel...");


                                chance = (int)generateur.Next(1, 3);

                                if (chance == 1)
                                {
                                    Console.WriteLine("malheureusement zoro a du se perdre dans la carte parce que l'ile ne ressemble pas a raftel");
                                }

                                if (chance == 2)
                                {
                                    Console.WriteLine("zoro regarde la carte et va sur l'emplacement indiquer sur la carte et zoro parviens a trouver le trésor de Roger sur la plage de l'ile. BIEN JOUÉ !!!!");
                                }
                            }
                        }

                       
                      }
                     

                   



                }







            }
        }
    }
}
