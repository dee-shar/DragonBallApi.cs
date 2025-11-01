# DragonBallApi.cs
Web-API for [dragonball-api.com](https://web.dragonball-api.com/about) a comprehensive REST API inspired by the iconic television series Dragon Ball. This API grants users access to an extensive database featuring hundreds of characters, images, transformations, and planets from the Dragon Ball universe

## Example
```cs
using TheDragonBallApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new DragonBallApi();
            string characters = await api.GetCharacters();
            Console.WriteLine(characters);
        }
    }
}
```
