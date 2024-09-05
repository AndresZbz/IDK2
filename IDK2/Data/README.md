# Levels system
IMPORTANT: The level read system was made following the Coding with Sphere tutorial, for more understanding watch that video.


In the root folder of IDK2 we will find the MapReader file, this read the csv exported file from Tiled (or another program that exports in csv I think).

## How to use it

Inside of your State code. Firstly load the MapReader and the files of the exported csv:

```cs
internal class TemplateState : State 
    {
        //load the mapReader and as a form of dictionary your csv file.
        MapReader mapReader;
        private Dictionary<Vector2, int> nameofthemap
        Texture2D textureAtlas;
        
        public TemplateState(Main game, GraphicsDevice graphics, ContentManager content) : base(game, graphics, content)
        {
            //initialize the mapReader
            mapReader = new MapReader();

            //load your tileset file ofc.
            textureAtlas = content.Load<Texture2D>("nameoftileset");

            //then load you file, these ../../../ are important
            nameofthemap = mapReader.loadMap("../../../folderInsideTheRoot/nameofthemap.csv");
        }

    }
```

Now to draw it just use this code inside the Draw method.

```cs

//Pixels size you want to draw.
int display_tile = 32;

//how many tiles are in your tileset per row
int num_tiles_per_row = 8;

//set tile pixel size
int pixel = 16;

//thanks to Coding with Sphere for the great tutorial.
foreach (var item in *name of your map*)
{
    Rectangle drect = new(
            (int)item.Key.X * display_tile,
            (int)item.Key.Y * display_tile,
            display_tile,
            display_tile
        );

    int x = item.Value % num_tiles_per_row;
    int y = item.Value / num_tiles_per_row;

    Rectangle src = new(
            x * pixel,
            y * pixel,
            pixel,
            pixel
        );

    spriteBatch.Draw(textureAtlas, drect, src, Color.White);
}

```

:)
