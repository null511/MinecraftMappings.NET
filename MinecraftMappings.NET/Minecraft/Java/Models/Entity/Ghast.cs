using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Ghast : JavaEntityModel
    {
        public Ghast() : base("Ghast")
        {
            AddVersion("ghast", "1.2.0")
                .WithTextureSize(64, 32)
                .AddElement("body", element => {
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 12f, -8f),
                        Size = new Vector3(16f, 16f, 16f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("tentacle1", element => {
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(2.7f, 5f, -6f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("tentacle2", element => {
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-7.3f, 4f, -6f),
                        Size = new Vector3(2f, 9f, 2f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("tentacle3", element => {
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2.3f, 0f, -6f),
                        Size = new Vector3(2f, 13f, 2f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("tentacle4", element => {
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(5.3f, 2f, -1f),
                        Size = new Vector3(2f, 11f, 2f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("tentacle5", element => {
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(0.3f, 2f, -1f),
                        Size = new Vector3(2f, 11f, 2f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("tentacle6", element => {
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4.7f, 3f, -1f),
                        Size = new Vector3(2f, 10f, 2f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("tentacle7", element => {
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(2.7f, 1f, 4f),
                        Size = new Vector3(2f, 12f, 2f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("tentacle8", element => {
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-7.3f, 1f, 4f),
                        Size = new Vector3(2f, 12f, 2f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("tentacle9", element => {
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2.3f, 4f, 4f),
                        Size = new Vector3(2f, 9f, 2f),
                        UV = new Vector2(0f, 0f),
                    });
                });
        }
    }
}
