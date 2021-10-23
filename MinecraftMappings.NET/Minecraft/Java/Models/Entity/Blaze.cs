using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Blaze : JavaEntityModel
    {
        public Blaze() : base("Blaze")
        {
            AddVersion("blaze", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("head", element => {
                    element.Translate = new Vector3(0f, 24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 20f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("stick1", element => {
                    element.Translate = new Vector3(-7f, 26f, -7f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(6f, 18f, -8f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("stick2", element => {
                    element.Translate = new Vector3(-7f, 26f, -7f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 18f, -8f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("stick3", element => {
                    element.Translate = new Vector3(7f, 26f, 7f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 18f, 6f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("stick4", element => {
                    element.Translate = new Vector3(-7f, 26f, 7f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(6f, 18f, 6f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("stick5", element => {
                    element.Translate = new Vector3(-5f, 22f, -5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 14f, -6f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("stick6", element => {
                    element.Translate = new Vector3(5f, 22f, -5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 14f, -6f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("stick7", element => {
                    element.Translate = new Vector3(5f, 22f, 5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 14f, 4f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("stick8", element => {
                    element.Translate = new Vector3(-5f, 22f, 5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 14f, 4f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("stick9", element => {
                    element.Translate = new Vector3(-3f, 14f, -3f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(2f, 6f, -4f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("stick10", element => {
                    element.Translate = new Vector3(3f, 14f, -3f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 6f, -4f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("stick11", element => {
                    element.Translate = new Vector3(3f, 14f, 3f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 6f, 2f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("stick12", element => {
                    element.Translate = new Vector3(-3f, 14f, 3f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(2f, 6f, 2f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                });
        }
    }
}
