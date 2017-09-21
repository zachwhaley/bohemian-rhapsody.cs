using System;
using System.Collections.Generic;

namespace queen
{
    // Is this the real life?
    // Is this just fantasy?
    // Caught in a landslide,
    // No escape from reality
    // Open your eyes,
    // Look up to the skies and see,
    // I'm just a poor boy, I need no sympathy,
    // Because I'm easy come, easy go
    // Little high, little low
    // Any way the wind blows doesn't really matter to me, to me
    class BohemianRhapsody
    {
        public BohemianRhapsody()
        {
            try
            {
                Assert(Life.Real);
                Assert(Life.Fantasy);
            }
            catch (LandSlideException)
            {
                Console.WriteLine("No escape from reality");
                #region Reality
                while (true)
                {
                    character.Eyes.ForEach(eye =>
                        eye.Open().Orient(Direction.Sky).See()
                    );
                    self.Wealth = null;
                    self.Sex = Sex.Male;

                    self.Sympathies.Clear();

                    if (self.ComeDifficulty == Difficulty.Easy &&
                        self.GoDifficulty == Difficulty.Easy &&
                        self.High < 0.1 &&
                        self.Low < 0.1)
                    {
                        switch (wind.Direction)
                        {
                            case Direction.North:
                            case Direction.East:
                            case Direction.South:
                            case Direction.West:
                            default:
                                self.Matter = false;
                                piano.Play();
                                break;
                        }
                    }
                }
                #endregion
            }
        }

        private static void Assert(Life? life)
        {
            if (life == Life.Real)
            {
                Console.WriteLine("Is this the real life?");
            }
            if (life == Life.Fantasy)
            {
                Console.WriteLine("Is this just fantasy?");
                throw new LandSlideException();
            }
        }

        private Person self = new Person();
        private Character character = new Character();
        private Wind wind = new Wind();
        private Piano piano = new Piano();
    }

    enum Sex
    {
        Male,
        Female,
        Other
    }

    enum Direction
    {
        North,
        East,
        South,
        West,
        Sky
    }

    enum Life
    {
        Real,
        Fantasy
    }

    struct Difficulty
    {
        public static int Easy = 0;
        public static int EasyGo = 1;
        public static int EasyCome = 2;

        public int Value { get; set; }

        public static bool operator ==(Difficulty difficulty, int value)
        {
            if (difficulty.Value == EasyCome)
                Console.Write("Because I'm easy come, ");
            else if (difficulty.Value == EasyGo)
                Console.WriteLine("easy go");
            return value == Easy;
        }

        public static bool operator !=(Difficulty difficulty, int value)
        {
            return !(difficulty == value);
        }

        public static implicit operator Difficulty(int value)
        {
            return new Difficulty { Value = value };
        }
    }

    struct Mood
    {
        public static string High = "high";
        public static string Low = "low";

        public string Value { get; set; }

        public static bool operator <(Mood mood, double value)
        {
            if (mood.Value == High)
                Console.Write("Little high, ");
            else if (mood.Value == Low)
                Console.WriteLine("little low");
            return value < 1;
        }

        public static bool operator >(Mood mood, double value)
        {
            return value > 1;
        }

        public static implicit operator Mood(string value)
        {
            return new Mood { Value = value };
        }
    }

    class Person
    {
        public float? Wealth
        {
            set { if (!value.HasValue) Console.Write("I'm just a poor "); }
        }
        public Sex Sex
        {
            set { if (value == Sex.Male) Console.Write("boy, "); }
        }
        public Sympathies Sympathies { get; } = new Sympathies();
        public Difficulty ComeDifficulty { get; } = Difficulty.EasyCome;
        public Difficulty GoDifficulty { get; } = Difficulty.EasyGo;
        public Mood High { get; } = Mood.High;
        public Mood Low { get; } = Mood.Low;
        public bool Matter
        {
            set { if (!value) Console.WriteLine("doesn't really matter to me, to me"); }
        }
    }

    class Sympathies
    {
        public void Clear()
        {
            Console.WriteLine("I need no sympathy,");
        }
    }

    class Character
    {
        public List<Eye> Eyes { get; } = new List<Eye> { new Eye() };
    }

    class Wind
    {
        public Direction Direction
        {
            get
            {
                Console.Write("Any way the wind blows ");
                var directions = Enum.GetValues(typeof(Direction));
                int anyway = new Random().Next(directions.Length);
                return (Direction)directions.GetValue(anyway);
            }
        }
    }

    class Piano
    {
        public void Play()
        {
            Console.WriteLine("🎶 🎶 🎶");
            throw new EndSongException();
        }
    }

    class Eye
    {
        public Eye Open()
        {
            Console.WriteLine("Open your eyes,");
            return this;
        }

        public Eye Orient(Direction direction)
        {
            string orientation = Direction.Sky == direction ? "skies" : "ground";
            Console.Write("Look up to the {0} ", orientation);
            return this;
        }

        public void See()
        {
            Console.WriteLine("and see,");
        }
    }

    class LandSlideException : Exception
    {
        public LandSlideException()
        {
            Console.WriteLine("Caught in a landslide,");
        }
    }

    class EndSongException : Exception
    {
    }
}
