using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Conduit : JavaEntityModel
    {
        public Conduit() : base("Conduit")
        {
            AddVersion("conduit", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("eye", element => {
                    element.Part = "eye";
                    element.Translate = new Vector3(0f, -8f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 4f, 0f),
                        Size = new Vector3(8f, 8f, 0f),
                        UV_North = UVMap(0f, 0f, 32f, 16f),
                        UV_East = UVMap(0f, 0f, 0f, 8f),
                        UV_South = UVMap(0f, 0f, 32f, 16f),
                        UV_West = UVMap(8f, 0f, 8f, 8f),
                        UV_Up = UVMap(8f, 0f, 0f, 0f),
                        UV_Down = UVMap(16f, 0f, 8f, 0f),
                    });
                })
                .AddElement("cage", element => {
                    element.Part = "cage";
                    element.Translate = new Vector3(0f, -8f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 4f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV_North = UVMap(32f, 32f, 16f, 16f),
                        UV_East = UVMap(16f, 32f, 0f, 16f),
                        UV_South = UVMap(64f, 32f, 48f, 16f),
                        UV_West = UVMap(48f, 32f, 32f, 16f),
                        UV_Up = UVMap(32f, 16f, 16f, 0f),
                        UV_Down = UVMap(48f, 16f, 32f, 0f),
                    });
                })
                .AddElement("base", element => {
                    element.Part = "base";
                    element.Translate = new Vector3(0f, -8f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 5f, -3f),
                        Size = new Vector3(6f, 6f, 6f),
                        UV_North = UVMap(24f, 24f, 12f, 12f),
                        UV_East = UVMap(12f, 24f, 0f, 12f),
                        UV_South = UVMap(48f, 24f, 36f, 12f),
                        UV_West = UVMap(36f, 24f, 24f, 12f),
                        UV_Up = UVMap(24f, 12f, 12f, 0f),
                        UV_Down = UVMap(36f, 12f, 24f, 0f),
                    });
                })
                .AddElement("wind", element => {
                    element.Part = "wind";
                    element.Translate = new Vector3(0f, -8f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 0f, -8f),
                        Size = new Vector3(16f, 16f, 16f),
                        UV_North = UVMap(16f, 16f, 32f, 32f),
                        UV_East = UVMap(0f, 16f, 16f, 32f),
                        UV_South = UVMap(48f, 16f, 64f, 32f),
                        UV_West = UVMap(32f, 16f, 48f, 32f),
                        UV_Up = UVMap(32f, 16f, 16f, 0f),
                        UV_Down = UVMap(48f, 0f, 32f, 16f),
                    });
                });
        }
    }
}
