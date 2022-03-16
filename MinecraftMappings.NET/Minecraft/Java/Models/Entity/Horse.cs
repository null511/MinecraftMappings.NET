using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Horse : JavaEntityModel
    {
        public Horse() : base("Horse")
        {
            AddVersion("horse", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -22f, 9f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 28f, -11f),
                        Size = new Vector3(6f, 5f, 7f),
                        UV_North = UVMap(7f, 20f, 13f, 25f),
                        UV_East = UVMap(0f, 20f, 7f, 25f),
                        UV_South = UVMap(20f, 20f, 26f, 25f),
                        UV_West = UVMap(13f, 20f, 20f, 25f),
                        UV_Up = UVMap(13f, 20f, 7f, 13f),
                        UV_Down = UVMap(19f, 13f, 13f, 20f),
                    });
                })
                .AddElement("mouth", element => {
                    element.Part = "mouth";
                    element.Translate = new Vector3(0f, -22f, 9f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 28f, -16f),
                        Size = new Vector3(4f, 5f, 5f),
                        UV_North = UVMap(5f, 30f, 9f, 35f),
                        UV_East = UVMap(0f, 30f, 5f, 35f),
                        UV_South = UVMap(14f, 30f, 18f, 35f),
                        UV_West = UVMap(9f, 30f, 14f, 35f),
                        UV_Up = UVMap(9f, 30f, 5f, 25f),
                        UV_Down = UVMap(13f, 25f, 9f, 30f),
                    });
                })
                .AddElement("left_ear", element => {
                    element.Part = "left_ear";
                    element.Translate = new Vector3(0f, -23f, 9f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0.5f, 33f, -5.01f),
                        Size = new Vector3(2f, 3f, 1f),
                        UV_North = UVMap(20f, 17f, 22f, 20f),
                        UV_East = UVMap(19f, 17f, 20f, 20f),
                        UV_South = UVMap(23f, 17f, 25f, 20f),
                        UV_West = UVMap(22f, 17f, 23f, 20f),
                        UV_Up = UVMap(22f, 17f, 20f, 16f),
                        UV_Down = UVMap(24f, 16f, 22f, 17f),
                    });
                })
                .AddElement("right_ear", element => {
                    element.Part = "right_ear";
                    element.Translate = new Vector3(0f, -23f, 9f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 33f, -5.01f),
                        Size = new Vector3(2f, 3f, 1f),
                        UV_North = UVMap(20f, 17f, 22f, 20f),
                        UV_East = UVMap(19f, 17f, 20f, 20f),
                        UV_South = UVMap(23f, 17f, 25f, 20f),
                        UV_West = UVMap(22f, 17f, 23f, 20f),
                        UV_Up = UVMap(22f, 17f, 20f, 16f),
                        UV_Down = UVMap(24f, 16f, 22f, 17f),
                    });
                })
                .AddElement("neck", element => {
                    element.Part = "neck";
                    element.Translate = new Vector3(0f, -22f, 8.9f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 16f, -11f),
                        Size = new Vector3(4f, 12f, 7f),
                        UV_North = UVMap(7f, 42f, 11f, 54f),
                        UV_East = UVMap(0f, 42f, 7f, 54f),
                        UV_South = UVMap(18f, 42f, 22f, 54f),
                        UV_West = UVMap(11f, 42f, 18f, 54f),
                        UV_Up = UVMap(11f, 42f, 7f, 35f),
                        UV_Down = UVMap(15f, 35f, 11f, 42f),
                    });
                })
                .AddElement("mane", element => {
                    element.Part = "mane";
                    element.Translate = new Vector3(0f, -22f, 9f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 17f, -4f),
                        Size = new Vector3(2f, 16f, 2f),
                        UV_North = UVMap(58f, 38f, 60f, 54f),
                        UV_East = UVMap(56f, 38f, 58f, 54f),
                        UV_South = UVMap(62f, 38f, 64f, 54f),
                        UV_West = UVMap(60f, 38f, 62f, 54f),
                        UV_Up = UVMap(60f, 38f, 58f, 36f),
                        UV_Down = UVMap(62f, 36f, 60f, 38f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -13f, -6f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 11f, -11f),
                        Size = new Vector3(10f, 10f, 22f),
                        UV_North = UVMap(22f, 54f, 32f, 64f),
                        UV_East = UVMap(0f, 54f, 22f, 64f),
                        UV_South = UVMap(54f, 54f, 64f, 64f),
                        UV_West = UVMap(32f, 54f, 54f, 64f),
                        UV_Up = UVMap(32f, 54f, 22f, 32f),
                        UV_Down = UVMap(42f, 32f, 32f, 54f),
                        SizeAdd = 0.05f,
                    });
                })
                .AddElement("tail", element => {
                    element.Part = "tail";
                    element.Translate = new Vector3(0f, -21f, -11f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 7f, 11f),
                        Size = new Vector3(3f, 14f, 4f),
                        UV_North = UVMap(46f, 40f, 49f, 54f),
                        UV_East = UVMap(42f, 40f, 46f, 54f),
                        UV_South = UVMap(53f, 40f, 56f, 54f),
                        UV_West = UVMap(49f, 40f, 53f, 54f),
                        UV_Up = UVMap(49f, 40f, 46f, 36f),
                        UV_Down = UVMap(52f, 36f, 49f, 40f),
                    });
                })
                .AddElement("front_left_leg", element => {
                    element.Part = "front_left_leg";
                    element.Translate = new Vector3(4f, -10f, 9.1f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 0f, -11f),
                        Size = new Vector3(4f, 11f, 4f),
                        UV_North = UVMap(56f, 25f, 52f, 36f),
                        UV_East = UVMap(60f, 25f, 56f, 36f),
                        UV_South = UVMap(64f, 25f, 60f, 36f),
                        UV_West = UVMap(52f, 25f, 48f, 36f),
                        UV_Up = UVMap(52f, 25f, 56f, 21f),
                        UV_Down = UVMap(56f, 21f, 60f, 25f),
                    });
                })
                .AddElement("front_right_leg", element => {
                    element.Part = "front_right_leg";
                    element.Translate = new Vector3(-4f, -10f, 9.1f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 0f, -11f),
                        Size = new Vector3(4f, 11f, 4f),
                        UV_North = UVMap(52f, 25f, 56f, 36f),
                        UV_East = UVMap(48f, 25f, 52f, 36f),
                        UV_South = UVMap(60f, 25f, 64f, 36f),
                        UV_West = UVMap(56f, 25f, 60f, 36f),
                        UV_Up = UVMap(56f, 25f, 52f, 21f),
                        UV_Down = UVMap(60f, 21f, 56f, 25f),
                    });
                })
                .AddElement("back_left_leg", element => {
                    element.Part = "back_left_leg";
                    element.Translate = new Vector3(4f, -10f, -8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 0f, 7f),
                        Size = new Vector3(4f, 11f, 4f),
                        UV_North = UVMap(56f, 25f, 52f, 36f),
                        UV_East = UVMap(60f, 25f, 56f, 36f),
                        UV_South = UVMap(64f, 25f, 60f, 36f),
                        UV_West = UVMap(52f, 25f, 48f, 36f),
                        UV_Up = UVMap(52f, 25f, 56f, 21f),
                        UV_Down = UVMap(56f, 21f, 60f, 25f),
                    });
                })
                .AddElement("back_right_leg", element => {
                    element.Part = "back_right_leg";
                    element.Translate = new Vector3(-4f, -10f, -8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 0f, 7f),
                        Size = new Vector3(4f, 11f, 4f),
                        UV_North = UVMap(52f, 25f, 56f, 36f),
                        UV_East = UVMap(48f, 25f, 52f, 36f),
                        UV_South = UVMap(60f, 25f, 64f, 36f),
                        UV_West = UVMap(56f, 25f, 60f, 36f),
                        UV_Up = UVMap(56f, 25f, 52f, 21f),
                        UV_Down = UVMap(60f, 21f, 56f, 25f),
                    });
                });
            // TODO: headpiece, bit, saddle
        }
    }
}
