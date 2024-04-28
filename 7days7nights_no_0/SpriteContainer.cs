using System.Reflection;

namespace _7days7nights_no_0
{
    static internal class SpriteContainer
    {
        static public readonly Image[] walkRight =
        [
            GetImageFromExecutingAssembly("Kuno_walk1.png"),
            GetImageFromExecutingAssembly("Kuno_walk2.png"),
            GetImageFromExecutingAssembly("Kuno_walk3.png"),
            GetImageFromExecutingAssembly("Kuno_walk4.png"),
        ];

        static public readonly Image[] walkLeft =
        [
            GetImageFromExecutingAssembly("Kuno_left1.png"),
            GetImageFromExecutingAssembly("Kuno_left2.png"),
            GetImageFromExecutingAssembly("Kuno_left3.png"),
            GetImageFromExecutingAssembly("Kuno_left4.png"),
        ];

        static public readonly Image[] zombieWalkRight =
        [
            GetImageFromExecutingAssembly("Zom_walk1.png"),
            GetImageFromExecutingAssembly("Zom_walk2.png"),
            GetImageFromExecutingAssembly("Zom_walk3.png"),
            GetImageFromExecutingAssembly("Zom_walk4.png"),
            GetImageFromExecutingAssembly("Zom_walk5.png"),
            GetImageFromExecutingAssembly("Zom_walk6.png"),
            GetImageFromExecutingAssembly("Zom_walk7.png"),
            GetImageFromExecutingAssembly("Zom_walk8.png"),
        ];

        private static Image GetImageFromExecutingAssembly(string fileName)
        {
            using Stream? stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"_7days7nights_no_0.Sprites.{fileName}");
            if (stream is not null)
            {
                return Image.FromStream(stream);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
