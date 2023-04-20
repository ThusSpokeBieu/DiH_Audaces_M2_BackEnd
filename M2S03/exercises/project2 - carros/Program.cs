using carros;

Owner nicolas = new Owner(  "Nicolas Breno Novaes",
                            "299.396.010-50",
                            "(63) 99804-1322");

Owner cecilia = new Owner(  "Cecília Carla da Silva",
                            "110.208.411-50",
                            "(37) 98348-3911");

Owner isabela = new Owner(  "Isabela Luciana Pinto",
                            "694.037.477-90",
                            "(11) 98729-3196");


Car car1 = new Car( "Buggy",
                    "Buggy 1.6/ TST/ RS 1.6 4-Lug.",
                    "LVU-4557",
                    "Bege",
                    nicolas);

Car car2 = new Car("JPX",
                    "Jipe Montez 4x4 CD Teto R.",
                    "HRR-8147",
                    "Bege",
                    cecilia);

Car car3 = new Car("CHANGAN",
                    "MINI STAR Utility 1.0 8V 53cv (Furg",
                    "ANU-2758",
                    "Cinza",
                    isabela);

Console.Write(car1);