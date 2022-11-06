﻿using System.Collections.Generic;
using System.Linq;
using HogwartsPotions.Models;
using HogwartsPotions.Models.Entities;
using HogwartsPotions.Models.Enums;

namespace HogwartsPotions.Data
{
    public class DbInitializer
    {
        public static void Initialize(HogwartsContext context)
        {

            context.Database.EnsureCreated();

            if (context.Students.Any() || context.Rooms.Any())
            {
                return;
            }

            List<Room> rooms = new List<Room>
            {
            new Room { Capacity = 5 },
            new Room { Capacity = 5 }
            };

            foreach (Room room in rooms)
            {
                context.Rooms.Add(room);
            }

            context.SaveChanges();

            List<Student> students = new List<Student>
            {
            new Student{Name="Carson Alexander",HouseType = HouseType.Gryffindor, PetType = PetType.Cat, Room = rooms[0]},
            new Student{Name="Meredith Alonso",HouseType = HouseType.Gryffindor, PetType = PetType.Owl, Room = rooms[0]},
            new Student{Name="Arturo Anand",HouseType = HouseType.Gryffindor, PetType = PetType.Rat, Room = rooms[0]},
            new Student{Name="Gytis Barzdukas",HouseType = HouseType.Gryffindor, PetType = PetType.Cat, Room = rooms[0]},
            new Student{Name="Yan Li",HouseType = HouseType.Gryffindor, PetType = PetType.Rat, Room = rooms[0]},
            new Student{Name="Peggy Justice",HouseType = HouseType.Slytherin, PetType = PetType.Cat, Room = rooms[1]},
            new Student{Name="Laura Alexander",HouseType = HouseType.Slytherin, PetType = PetType.None, Room = rooms[1]},
            new Student{Name="Nino Alexander",HouseType = HouseType.Slytherin, PetType = PetType.Owl, Room = rooms[1]},
            new Student{Name="Arturo Olivetto",HouseType = HouseType.Slytherin, PetType = PetType.Owl, Room = rooms[1]},
            new Student{Name="Carson Norman",HouseType = HouseType.Slytherin, PetType = PetType.Cat, Room = rooms[1]},
            };

            foreach (Student s in students)
            {
                context.Students.Add(s);

            }

            context.SaveChanges();

            List<Ingredient> ingredients = new List<Ingredient>
            {
            new Ingredient {Name = "Abraxan hair", Description = "The hair of an Abraxan, unknown effect and usage."},
            new Ingredient {Name = "Aconite (Wolfsbane or Monkshhod)", Description = "Used in Wolfsbane potions, but also in the Wideye/Awakening Potion."},
            new Ingredient {Name = "Acromantula venom", Description = "Venom of the Acromantula spider: because of its rarity, it can sell for about one hundred Galleons a pint, and is an ingredient in the Armadillo Bile Mixture."},
            new Ingredient {Name = "Adder's Fork", Description = "The tongue of an Adder snake, unknown use and effect."},
            new Ingredient {Name = "African Red Pepper", Description = "Used in Piquant Toothpaste and Dentifricium Mouthwash."},
            new Ingredient {Name = "African Sea Salt", Description = "Used in Draught of Living Death."},
            new Ingredient {Name = "Agrippa", Description = "Used in Agrippa potions."},
            new Ingredient {Name = "Alcohol", Description = "Ethanol, used in Elixir 7 and Pepperup Elixir."},
            new Ingredient {Name = "Alihotsy", Description = "Used in the Laughing Potion and Alihotsy Draught; the leaves cause uncontrollable laughter."},
            new Ingredient {Name = "Angel's Trumpet", Description = "Angel's Trumpet is used as an ingredient in Angel's Trumpet Draught and the Tonic for Trace Detection, and is a highly poisonous plant."},
            new Ingredient {Name = "Anjelica", Description = "Magical herb with unknown effects and uses."},
            new Ingredient {Name = "Antimony", Description = "No known usage or effect, but it is also used in its molten form."},
            new Ingredient {Name = "Armadillo Bile", Description = "Used in the Wit-Sharpening Potion."},
            new Ingredient {Name = "Armotentia", Description = "The main component in the Armadillo Bile Mixture."},
            new Ingredient {Name = "Arnica", Description = "Poisonous plant, used in the Syrup of this plant, an ingredient itself ."},
            new Ingredient {Name = "Asian Dragon Hair", Description = "Used in Sleekeazy's Hair Potion"},
            new Ingredient {Name = "Ashwinder egg", Description = "The eggs of an Ashwinder are used in Love Potions, Felix Felicis and as an antidote to ague."},
            new Ingredient {Name = "Asphodel", Description = "The powdered roots of Asphodel are used in the Draught of Living Death and the Wiggenweld Potion."},
            new Ingredient {Name = "Balm", Description = "Used in the The Famous French Method for the Bite of a Mad Dog."},
            new Ingredient {Name = "Banana", Description = "Used in the Ageing Potion."},
            new Ingredient {Name = "Baneberry", Description = "Poisonous plant; used in the Baneberry Potion and the Tonic for Trace Detection."},
            new Ingredient {Name = "Bat spleen", Description = "Used in the Swelling Solution."},
            new Ingredient {Name = "Bat wing", Description = "Used in the corrosive Armadillo Bile Mixture"},
            new Ingredient {Name = "Beetle Eye", Description = "The eyes of Beetles, Common ingredient."},
            new Ingredient {Name = "Belladonna", Description = "Fluids are used in part of a standard potion making-kit. Believed to be a key ingredient in witches' flying ointment."},
            new Ingredient {Name = "Betony", Description = "Used in the The Famous French Method for the Bite of a Mad Dog."},
            new Ingredient {Name = "Bezoar", Description = "Acts as an antidote to most poisons, with the exception of Basilisk venom."},
            new Ingredient {Name = "Bicorn Horn", Description = "Powdered horns are used in Polyjuice Potion."},
            new Ingredient {Name = "Billywig sting", Description = "Has the ability to make a person float. Used in a variety of potions, including Antidote to Uncommon Poisons and the Wideye Potion."},
            new Ingredient {Name = "Billywig Sting Slime", Description = "Has curative properties. Used in the Wiggenweld Potion."},
            new Ingredient {Name = "Billywig wings", Description = "Used in the Laughing Potion"},
            new Ingredient {Name = "Bitter root", Description = "Used in the Burning Bitterroot Balm"},
            new Ingredient {Name = "Blatta Pulvereus", Description = "Unknown origin and effect, presumably crushed insects."},
            new Ingredient {Name = "Blind-worm's Sting", Description = "The sting of a Blind-worm, unknown effect and usage."},
            new Ingredient {Name = "Blood", Description = "Properties depend on the source. Unicorn blood can keep a person alive, while Re'em blood gives the drinker immense strength for a short time. Blood of a foe is used in the Dark Regeneration potion"},
            new Ingredient {Name = "Bloodroot", Description = "Poisonous plant, which kills animal cells, used as the main ingredient in Bloodroot Poison."},
            new Ingredient {Name = "Blowfly", Description = "Common name for flies, unknown effect and usage."},
            new Ingredient {Name = "Bone", Description = "Used in the Regeneration potion."},
            new Ingredient {Name = "Boom Berry", Description = "Restorative properties. Used in the Wiggenweld Potion."},
            new Ingredient {Name = "Boomslang", Description = "Venom is highly poisonous, but slow to act. Skin used a potion ingredient."},
            new Ingredient {Name = "Boomslang Skin", Description = "An unusual ingredient used in Polyjuice Potion and Beautification Potion."},
            new Ingredient {Name = "Borage", Description = "Plant or herb with unknown effects and usage."},
            new Ingredient {Name = "Bouncing Bulb", Description = "Used in Pompion Potion."},
            new Ingredient {Name = "Bouncing Spider Juice", Description = "Standard ingredient in potion making."},
            new Ingredient {Name = "Bubotuber pus", Description = "Has acne-ridding qualities, as well as an ingredient in Fake protective potions and the Healing Potion."},
            new Ingredient {Name = "Bulbadox juice", Description = "Magical substance which can causes breakouts of boils, used in the brewing of the Tonic for Trace Detection."},
            new Ingredient {Name = "Bundimun Secretion", Description = "Used in Doxycide, Bundimun Pomade and various cleaning products."},
            new Ingredient {Name = "Bursting mushroom", Description = "Used in the Fire Protection Potion."},
            new Ingredient {Name = "Butterscotch", Description = "Sweet substance, used in the Dawdle Draught."},
            new Ingredient {Name = "Camphirated Spirit", Description = "Used in The Famous French Method for the Bite of a Mad Dog."},
            new Ingredient {Name = "Castor oil", Description = "Used in the Love Potion Antidote."},
            new Ingredient {Name = "Cat Hair", Description = "Standard potion-making ingredient."},
            new Ingredient {Name = "Caterpillar", Description = "Sliced caterpillars are used in the Shrinking Solution."},
            new Ingredient {Name = "Centaury", Description = "Used in The Famous French Method for the Bite of a Mad Dog."},
            new Ingredient {Name = "Cheese", Description = "Used in Cheese-Based Potions."},
            new Ingredient {Name = "Chicken Lips", Description = "The lips of a chicken, unknown effects and usage."},
            new Ingredient {Name = "Chinese Chomping Cabbage", Description = "Magical plant. Used in the Skele-Gro Potion."},
            new Ingredient {Name = "Chizpurfle Carapace", Description = "Used in the Antidote to Uncommon Poisons."},
            new Ingredient {Name = "Chizpurfle fang", Description = "Used in the Wiggenweld Potion."},
            new Ingredient {Name = "Cinnamon", Description = "Common spice, standard potion-making ingredient."},
            new Ingredient {Name = "Cockroach", Description = "Small brown insect, unknown effect and usage."},
            new Ingredient {Name = "Cowbane", Description = "Poisonous plant, used in Doxycide and Shrinking Solution."},
            new Ingredient {Name = "Crocodile Heart", Description = "Unknown effect and usage."},
            new Ingredient {Name = "Daisy", Description = "Its roots are used in the Shrinking Solution."},
            new Ingredient {Name = "Dandelion root", Description = "Standard potion-making ingredient."},
            new Ingredient {Name = "Dandruff", Description = "Optional ingredient for the Polyjuice Potion."},
            new Ingredient {Name = "Deadlyius", Description = "Unknown effect. Most likely a poisonous fungi."},
            new Ingredient {Name = "Death-Cap", Description = "Extremely Poisonous mushroom. Used in the Death-Cap Draught."},
            new Ingredient {Name = "Dittany", Description = "Powerful healing herb. Promotes skin growth, to the point of making a fresh wound seem several days old. An ingredient in the Wiggenweld Potion and Mixture of powdered silver and dittany, the latter of which is used to cure Werewolf bites, along with the Healing Potion."},
            new Ingredient {Name = "Doxy egg", Description = "Highly poisonous egg of the Doxy, used in the Girding Potion."},
            new Ingredient {Name = "Dragon blood", Description = "Has a number of properties. May be used as an oven cleaner, spot remover, a cure for verruca and potion ingredient."},
            new Ingredient {Name = "Dragon claw", Description = "When powdered and eaten, gives the consumer a 'brain boost', as well as ingredient in Tolipan Blemish Blitzer."},
            new Ingredient {Name = "Dragon Claw Ooze", Description = "Unknown effect and usage."},
            new Ingredient {Name = "Dragon dung", Description = "Used as a fertiliser, particularly the Dragon-Dung Fertiliser."},
            new Ingredient {Name = "Dragon horn", Description = "Common ingredient. Used in the Fire-Breathing Potion."},
            new Ingredient {Name = "Dragon liver", Description = "Liver of a dragon, used in the making of the Healing Potion."},
            new Ingredient {Name = "Dragonfly thorax", Description = "When toasted, can be used in the Girding Potion and the Dragon-Dung Fertiliser."},
            new Ingredient {Name = "Eagle Owl Feather", Description = "Used in the Dragon Tonic."},
            new Ingredient {Name = "Eel eye", Description = "Used in the Bulgeye Potion."},
            new Ingredient {Name = "Erumpent horn", Description = "Powerful magical properties. Contains a deadly fluid that causes whatever it is injected into to explode. Used in the Tonic for Trace Detection"},
            new Ingredient {Name = "Erumpent tail", Description = "Unknown effect and usage."},
            new Ingredient {Name = "Essence of comfrey", Description = "Organic oil, unknown effect and usage."},
            new Ingredient {Name = "Essence of Daisyroot", Description = "Unknown effect and usage."},
            new Ingredient {Name = "Exploding Fluid", Description = "Gives the Erumpent Horn its explosive quality."},
            new Ingredient {Name = "Exploding Ginger Eyelash", Description = "Unknown effect. Used in a standard potion-making kit."},
            new Ingredient {Name = "Eye of Newt", Description = "Unknown effect and usage."},
            new Ingredient {Name = "Eyeball", Description = "Unknown effect and usage."},
            new Ingredient {Name = "Fairy Wing", Description = "Rare ingredient, as fairies are difficult to capture. Found in the Girding Potion and Beautification Potion."},
            new Ingredient {Name = "Fanged Geranium", Description = "Fangs used as potion ingredients."},
            new Ingredient {Name = "Fillet of a Fenny Snake", Description = "Unknown effect."},
            new Ingredient {Name = "Fire", Description = "Used in the heating and brewing of potions."},
            new Ingredient {Name = "Firefly", Description = "Small flying insects, unknown effect and usage."},
            new Ingredient {Name = "Fire Seed", Description = "Seed of the Fire Seed Bush, maintains high temperatures, used in the Fire-Breathing Potion and Antidote to Uncommon Poisons."},
            new Ingredient {Name = "Flabberghasted Leech", Description = "Unknown effect."},
            new Ingredient {Name = "Flesh", Description = "The flesh of living beings, including humans"},
            new Ingredient {Name = "Flitterby", Description = "Moths used in potions."},
            new Ingredient {Name = "Flobberworm Mucus", Description = "Mucus of the Flobberworm, used as a common thickener in potions. A vital ingredient in the Wiggenweld Potion, Cure for Boils, Herbicide Potion and Sleeping Draught."},
            new Ingredient {Name = "Flower head", Description = "Unknown effect and usage."},
            new Ingredient {Name = "Fluxweed", Description = "Known for its healing properties. Used in the Polyjuice Potion if picked at the full moon."},
            new Ingredient {Name = "Flying Seahorses", Description = "Used in the Girding Potion"},
            new Ingredient {Name = "Foxglove", Description = "Poisonous plant, used in the Pompion Potion."},
            new Ingredient {Name = "Frog", Description = "Small green amphibians, parts used as potion ingredients, such as the Frog Parts Mixture."},
            new Ingredient {Name = "Frog brain", Description = "The brain of a frog, used in Baruffio's Brain Elixir."},
            new Ingredient {Name = "Galanthus Nivalis", Description = "Commonly known as Snowdrop, unknown effect."},
            new Ingredient {Name = "Giant Purple Toad Wart", Description = "Difficult to extract, given the toads' tendency to disappear. Used in the Dragon Tonic."},
            new Ingredient {Name = "Ginger Root", Description = "Used in the Wit-Sharpening Potion."},
            new Ingredient {Name = "Gomas Barbadensis", Description = "Used in Sleekeazy's Hair Potion."},
            new Ingredient {Name = "Goosegrass", Description = "Used for skin ailments and scurvy. May produce a red dye."},
            new Ingredient {Name = "Granian hair", Description = "Unknown effect."},
            new Ingredient {Name = "Graphorn horn", Description = "The horn of the Graphorn, extremely expensive and an ingredient in the Antidote to Uncommon Poisons"},
            new Ingredient {Name = "Gravy", Description = "Used in Fake Protective Potions."},
            new Ingredient {Name = "Griffin Claw", Description = "When powdered, used in the Strengthening Solution."},
            new Ingredient {Name = "Gillyweed", Description = "When ingested, allows the user to grow gills and webbing between their fingers and toes. Unknown usage in potion-making."},
            new Ingredient {Name = "Gnat Heads", Description = "Unknown effect."},
            new Ingredient {Name = "Gulf", Description = "Unknown effect."},
            new Ingredient {Name = "Gurdyroot", Description = "Essence of Gurdyroot used in Love Potion Antidote"},
            new Ingredient {Name = "Haliwinkles", Description = "Unknown effect. Presumably a plant or animal."},
            new Ingredient {Name = "Hellebore", Description = "Poisonous plant, used in the Syrup of Hellebore, a potion ingredient in itself."},
            new Ingredient {Name = "Hemlock", Description = "Poisonous plant, used in Doxycide."},
            new Ingredient {Name = "Herbaria", Description = "Unknown effect."},
            new Ingredient {Name = "Hermit crab shell", Description = "Used in the Dawdle Draught."},
            new Ingredient {Name = "Honey", Description = "Used in Honeywater, in a variety of potions."},
            new Ingredient {Name = "Honeywater", Description = "Drops are used in the Wiggenweld Potion, while larger quantities are used in the Volubilis Potion and the Antidote to Common Poisons."},
            new Ingredient {Name = "Horklump juice", Description = "Used in a range of healing potions, including the Wiggenweld Potion, as well as the poisonous Herbicide Potion."},
            new Ingredient {Name = "Horned slug", Description = "When stewed, used in the Boil-Cure Potion."},
            new Ingredient {Name = "Horned toad", Description = "Unknown effect."},
            new Ingredient {Name = "Horse hair", Description = "Unknown effect."},
            new Ingredient {Name = "Horseradish", Description = "Perennial plant; powdered ingredient in the Laughing Potion."},
            new Ingredient {Name = "Howlet's Wing", Description = "Unknown effect."},
            new Ingredient {Name = "Iguana blood", Description = "The blood of an Iguana, unknown effect and usage."},
            new Ingredient {Name = "Infusion of Wormwood", Description = "Used in Draught of Living Death, Elixir to Induce Euphoria, Shrinking Solution and Vitamix Potion."},
            new Ingredient {Name = "Jewelweed", Description = "Plant, used in Fergus Fungal Budge."},
            new Ingredient {Name = "Jobberknoll feather", Description = "Used in Truth Serums and Memory Potions."},
            new Ingredient {Name = "Kelp", Description = "Used in common Fertiliser."},
            new Ingredient {Name = "Knarl quills", Description = "Used in the Laughing Potion."},
            new Ingredient {Name = "Knotgrass", Description = "Magical properties. Used in the Polyjuice Potion"},
            new Ingredient {Name = "Lacewing Fly", Description = "When stewed for 21 days, used in the Polyjuice Potion"},
            new Ingredient {Name = "Lady's Mantle", Description = "A plant with magical properties. Used in Beautification Potion."},
            new Ingredient {Name = "Lavender", Description = "Flower with calming influence and pleasant smell, used in the Fire-Breathing Potion and the Sleeping Draught."},
            new Ingredient {Name = "Leech", Description = "Used in the Polyjuice Potion ."},
            new Ingredient {Name = "Leech Juice", Description = "Used in the Shrinking Solution."},
            new Ingredient {Name = "Left handed nazle powder", Description = "Magical powder, unknown effect and usage."},
            new Ingredient {Name = "Lethe River Water", Description = "Used in Memory Potion."},
            new Ingredient {Name = "Lionfish", Description = "Venomous fish, spines used as potion ingredient, as well as an powdered ingredient in the poisonous Potion N. 07."},
            new Ingredient {Name = "Lionfish Spine", Description = "When crushed into powder or used whole, used in healing potions, including Wiggenweld Potion, and the Herbicide Potion"},
            new Ingredient {Name = "Liver", Description = "Offal of humans and animals, used in potions."},
            new Ingredient {Name = "Lizard's Leg", Description = "The leg of a lizard, unknown effect and usage."},
            new Ingredient {Name = "Lobalug Venom", Description = "The venom of a Lobalug, unknown effect and usage."},
            new Ingredient {Name = "Lovage", Description = "Used in the Confusing Concoction and Befuddlement Draught."},
            new Ingredient {Name = "Mackled Malaclaw tail", Description = "Tail of a Mackled Malaclaw, unknown effect and usage."},
            new Ingredient {Name = "Mallowsweet", Description = "Magical herb with unknown effect and usage."},
            new Ingredient {Name = "Mandrakeď»ż", Description = "Used in the Mandrake Restorative Draught."},
            new Ingredient {Name = "Mandrake, stewed", Description = "Used in the Mandrake Restorative Draught, Wiggenweld Potion, Oculus Potion and Volubilis Potion."},
            new Ingredient {Name = "Mandrake Root", Description = "Used in the Pepperup Potion."},
            new Ingredient {Name = "Maw", Description = "Unknown origin and effect."},
            new Ingredient {Name = "Mercury and Mars", Description = "Unknown usage, probably poisonous."},
            new Ingredient {Name = "Mistletoe Berry", Description = "Used in the Antidote in Common Poisons."},
            new Ingredient {Name = "Mint", Description = "Used in The Famous French Method for the Bite of a Mad Dog and the Fire-Breathing Potion."},
            new Ingredient {Name = "Moly", Description = "Used in the Wiggenweld Potion."},
            new Ingredient {Name = "Moondew", Description = "Used in the Wiggenweld Potion, Draught of Living Death and Antidote to Common Poisons."},
            new Ingredient {Name = "Moonseed", Description = "Used in the Moonseed Poison."},
            new Ingredient {Name = "Moonstone", Description = "Used in Draught of Peace, Love Potions, and Potion No. 86."},
            new Ingredient {Name = "Morning dew", Description = "Used in the Beautification Potion."},
            new Ingredient {Name = "Motherwort", Description = "Used in The Famous French Method for the Bite of a Mad Dog."},
            new Ingredient {Name = "Murtlap tentacle", Description = "Used in Murtlap Essence and Felix Felicis."},
            new Ingredient {Name = "Mushroom", Description = "Various types of fungi can be used as potion ingredients."},
            new Ingredient {Name = "Nagini's venom", Description = "Used in the Rudimentary body potion."},
            new Ingredient {Name = "Neem oil", Description = "Essential oil extracted from the seeds of the Neem tree, used in the Fergus Fungal Budge."},
            new Ingredient {Name = "Nettle", Description = "Dried Nettles in Cure for Boils."},
            new Ingredient {Name = "Newt", Description = "Eyes and spleen used as potion ingredients."},
            new Ingredient {Name = "Newt spleen", Description = "Used in the Ageing Potion."},
            new Ingredient {Name = "Niffler's Fancy", Description = "Used in the Potion of All Potential."},
            new Ingredient {Name = "Nightshade", Description = "Plants with unknown effect and usage."},
            new Ingredient {Name = "Nux Myristica", Description = "Magical plant with unknown effects and usage."},
            new Ingredient {Name = "Occamy egg", Description = "Used in Occamy Egg Yolk Shampoo and Felix Felicis."},
            new Ingredient {Name = "Octopus Powder", Description = "Used to strengthen potions."},
            new Ingredient {Name = "Onion juice", Description = "Used in Fergus Fungal Budge."},
            new Ingredient {Name = "Peacock feather", Description = "Used in Dragon Tonic."},
            new Ingredient {Name = "Pearl Dust", Description = "Used in Love Potions."},
            new Ingredient {Name = "Peppermint", Description = "Sprigs used in the Elixir to Induce Euphoria."},
            new Ingredient {Name = "Petroleum Jelly", Description = "Used in Sleekeazy's Hair Potion."},
            new Ingredient {Name = "Pickled Slugs", Description = "Unknown effect and usage"},
            new Ingredient {Name = "Plangentine", Description = "Unknown effect and usage."},
            new Ingredient {Name = "Plantain", Description = "Used in The Famous French Method for the Bite of a Mad Dog."},
            new Ingredient {Name = "Poison ivy", Description = "Poisonous plant, unknown usage."},
            new Ingredient {Name = "Polypody", Description = "Used in The Famous French Method for the Bite of a Mad Dog."},
            new Ingredient {Name = "Pomegranate juice", Description = "Unknown usage and effect."},
            new Ingredient {Name = "Pond Slime", Description = "Unknown usage and effect."},
            new Ingredient {Name = "Poppy head", Description = "Unknown usage and effect."},
            new Ingredient {Name = "Powder of vipers-flesh", Description = "Used in The Famous French Method for the Bite of a Mad Dog."},
            new Ingredient {Name = "Porcupine quill", Description = "Used in the Cure for Boils, Elixir to Induce Euphoria, Hair-Raising Potion and Draught of Peace."},
            new Ingredient {Name = "Pritcher's Porritch", Description = "Used in the Potion of All Potential."},
            new Ingredient {Name = "Ptolemy", Description = "Blood red magical substance, unknown effect and usage."},
            new Ingredient {Name = "Puffer-fish", Description = "Used in Skele-Gro."},
            new Ingredient {Name = "Puffer-fish Eyes", Description = "Eyes of Puffer-fish, used in the Swelling Solution."},
            new Ingredient {Name = "Puffskein hair", Description = "Hair of the Puffskein, used in the Laughing Potion."},
            new Ingredient {Name = "Pungous Onion", Description = "Magical plant, used in the Cure for Boils."},
            new Ingredient {Name = "Pus", Description = "The pus of certain plants, such as Bubotubers, can be used as potion ingredients."},
            new Ingredient {Name = "Rat spleen", Description = "Used in Dragon dung Fertiliser, Shrinking Solution and the Rat Spleen Mixture."},
            new Ingredient {Name = "Rat tail", Description = "Used in the Hair-Raising Potion."},
            new Ingredient {Name = "Re'em blood", Description = "Used in the Exstimulo Potion."},
            new Ingredient {Name = "Rose", Description = "Common garden plant, with many of its parts used in potion-making."},
            new Ingredient {Name = "Rose Petals", Description = "Used in the Beautification Potion and Love Potions."},
            new Ingredient {Name = "Rose thorn", Description = "Used in Love Potions."},
            new Ingredient {Name = "Rose oil", Description = "Essential oil of the Rose plant, unknown effect and usage."},
            new Ingredient {Name = "Rotten egg", Description = "Decomposed eggs, unknown effects and usage."},
            new Ingredient {Name = "Rue", Description = "Evergreen shrubs, with healing properties: essence used to recover from poisoning, as well as an ingredient in The Famous French Method for the Bite of a Mad Dog and Felix Felicis."},
            new Ingredient {Name = "Runespoor egg", Description = "Used in Baruffio's Brain Elixir."},
            new Ingredient {Name = "Russian's Dragon Nails", Description = "Unknown effects and usage."},
            new Ingredient {Name = "Sage", Description = "Used in the Boil Bursting Unction and the Memory Potion."},
            new Ingredient {Name = "Sal Ammoniac", Description = "Used in Panacea."},
            new Ingredient {Name = "Salamander blood", Description = "Used in the Strengthening Solution and Wiggenweld Potion."},
            new Ingredient {Name = "Salpeter", Description = "Magical substance with unknown properties and effects."},
            new Ingredient {Name = "Salt", Description = "Used in Panacea and in salt water."},
            new Ingredient {Name = "Saltpetre", Description = "another term for Potassium nitrate, unknown effect and usage in potion-making."},
            new Ingredient {Name = "Salt water", Description = "Used in the Treatment for scale rot."},
            new Ingredient {Name = "Sardine", Description = "Fish, unknown usage and fish."},
            new Ingredient {Name = "Scale of Dragon", Description = "Scale of a dragon, unknown effect."},
            new Ingredient {Name = "Scarab beetle", Description = "Used in Skele-Gro."},
            new Ingredient {Name = "Scurvy grass", Description = "Used in Befuddlement Draught."},
            new Ingredient {Name = "Shrake spine", Description = "Used in Zygmunt Budge's version of the Cure for Boils."},
            new Ingredient {Name = "Shrivelfig", Description = "Used in Elixir to Induce Euphoria and Shrinking Solution."},
            new Ingredient {Name = "Silver", Description = "Used in the Mixture of powdered silver and dittany."},
            new Ingredient {Name = "Silverweed", Description = "Plant in the Rose family, unknown effect and usage."},
            new Ingredient {Name = "Sloth brain", Description = "Mucus used in Draught of Living Death and Dragon dung Fertiliser."},
            new Ingredient {Name = "Snake fang", Description = "Used in Cure for Boils, Wideye Potion and Strength Potion."},
            new Ingredient {Name = "Snake skin", Description = "Skin of snakes used in various potions."},
            new Ingredient {Name = "Snakeweed", Description = "Magical plant, unknown effect."},
            new Ingredient {Name = "Sneezewort", Description = "Poisonous plant, used in the Befuddlement Draught."},
            new Ingredient {Name = "Sopophorous bean", Description = "Used in the Draught of Living Death"},
            new Ingredient {Name = "Sopophorous plant", Description = "Beans used as ingredients."},
            new Ingredient {Name = "Spiders", Description = "Small arachnids, used in various potions with different effects."},
            new Ingredient {Name = "Spirit of Myrrh", Description = "Used in the The Famous French Method for the Bite of a Mad Dog."},
            new Ingredient {Name = "Spleenwart", Description = "Magical plant, unknown effect and usage."},
            new Ingredient {Name = "Squill", Description = "Bulb of plant used as an ingredient in itself."},
            new Ingredient {Name = "Squill bulb", Description = "Bulb of the Squill plant, used in Felix Felicis."},
            new Ingredient {Name = "St John's-wort", Description = "Used in The Famous French Method for the Bite of a Mad Dog."},
            new Ingredient {Name = "Staghorn", Description = "Fungi, unknown effects and usage."},
            new Ingredient {Name = "Standard Ingredient", Description = "Dried herbs used as ingredient in many potions."},
            new Ingredient {Name = "Star Grass", Description = "Medicinal herb used in the Star Grass Salve."},
            new Ingredient {Name = "Starthistle", Description = "Magical plant, unknown effect and usage."},
            new Ingredient {Name = "Streeler shells", Description = "Highly poisonous shells of the Streeler, used in the brewing of Doxycide."},
            new Ingredient {Name = "Sulphur Vive", Description = "Used in the Panacea."},
            new Ingredient {Name = "Syrup of Arnica", Description = "Poisonous substance extracted from its plant, unknown effects and usage."},
            new Ingredient {Name = "Syrup of Hellebore", Description = "Used in Draught of Peace, Volubilis Potion and Potion No. 86."},
            new Ingredient {Name = "Tar", Description = "Used in the Treatment for scale rot."},
            new Ingredient {Name = "Thaumatagoria", Description = "Used in the Potion of All Potential."},
            new Ingredient {Name = "Thyme", Description = "Tincture of Thyme used in Felix Felicis."},
            new Ingredient {Name = "Tincture of Demiguise", Description = "Substance extracted from Demiguises, unknown effect and usage."},
            new Ingredient {Name = "Toe of Frog", Description = "The toe of a frog, unknown effect and usage."},
            new Ingredient {Name = "Tongue of Dog", Description = "The tongue of a dog, unknown effect and usage."},
            new Ingredient {Name = "Tooth of Wolf", Description = "The tooth of a wolf, unknown effect and usage."},
            new Ingredient {Name = "Tormentil", Description = "Used in Zygmunt Budge's version of Doxycide."},
            new Ingredient {Name = "Tubeworm", Description = "Worm-like aquatic creatures, unknown effect and usage."},
            new Ingredient {Name = "Turtle Shell", Description = "Unknown effect and usage."},
            new Ingredient {Name = "Unicorn Blood", Description = "Used in the Rudimentary body potion."},
            new Ingredient {Name = "Unicorn Hair", Description = "Used in the Beautification Potion"},
            new Ingredient {Name = "Unicorn Horn", Description = "Used in the Antidote to Common Poisons, Draught of Peace and the Wiggenweld Potion."},
            new Ingredient {Name = "Urine", Description = "Used in Panacea"},
            new Ingredient {Name = "Valerian", Description = "Plant used in Forgetfulness Potion, Sleeping Draught and Fire-Breathing Potion."},
            new Ingredient {Name = "Valerian root", Description = "Root of plant used in Draught of Peace and Draught of Living Death."},
            new Ingredient {Name = "Venomous Tentacula", Description = "Poisonous and dangerous plant; essence of Venomous Tentacula used in the poisonous Potion N. 07, as well as leaves used as ingredients."},
            new Ingredient {Name = "Venomous Tentacula leaf", Description = "Leaves from the poisonous plant; unknown effect and usage but highly valuable on the market."},
            new Ingredient {Name = "Vervain", Description = "Medicinal plant used in The Famous French Method for the Bite of a Mad Dog."},
            new Ingredient {Name = "Vervain infusion", Description = "Preparation of Vervain, with healing properties."},
            new Ingredient {Name = "Vinegar", Description = "Used in Panacea."},
            new Ingredient {Name = "Wartcap powder", Description = "Used in the Fire Protection Potion."},
            new Ingredient {Name = "Wartizome", Description = "Magical plant, unknown effect and usage."},
            new Ingredient {Name = "Water", Description = "Used as standard liquid component of all potions."},
            new Ingredient {Name = "White spirit", Description = "Used in the Treatment for scale rot."},
            new Ingredient {Name = "White Wine", Description = "Used as the liquid component in The Famous French Method for the Bite of a Mad Dog."},
            new Ingredient {Name = "Wiggenbush", Description = "Plant with unknown effects and usage."},
            new Ingredient {Name = "Wiggenbush bark", Description = "Bark of plant with unknown effects and usage."},
            new Ingredient {Name = "Wiggentree", Description = "Protective plant, bark used as potion ingredient."},
            new Ingredient {Name = "Wiggentree bark", Description = "Used in the Wiggenweld Potion."},
            new Ingredient {Name = "Witch's Ganglion", Description = "Used in the Potion of All Potential."},
            new Ingredient {Name = "Witches' Mummy", Description = "Substance with unknown effect and usage."},
            new Ingredient {Name = "Woodlice Extract 63", Description = "Substance with unknown effect and usage."},
            new Ingredient {Name = "Wood louse", Description = "Small insects with unknown effect and usage."},
            new Ingredient {Name = "Wool of Bat", Description = "Unknown effect and usage."},
            new Ingredient {Name = "Wormwood", Description = "Bitter herb, essence and infusion of this plant used as common potion ingredients, plant itself used in Healing Potion."},
            new Ingredient {Name = "Wormwood Essence", Description = "Unknown effect and usage."}
            };

            foreach (Ingredient ingredient in ingredients)
            {
                context.Ingredients.Add(ingredient);
            }

            context.SaveChanges();

        }
    }
}