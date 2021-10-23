using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Creeper : JavaEntityModel
    {
        public Creeper() : base("Creeper")
        {
            AddVersion("creeper", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("head", element => {
                    element.Translate = new Vector3(0f, -18f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 18f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -18f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 6f, -2f),
                        Size = new Vector3(8f, 12f, 4f),
                        UV = new Vector2(16f, 16f),
                    });
                })
                .AddElement("leg1", element => {
                    element.Translate = new Vector3(-2f, -6f, -4f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 0f, 2f),
                        Size = new Vector3(4f, 6f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("leg2", element => {
                    element.Translate = new Vector3(2f, -6f, -4f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, 2f),
                        Size = new Vector3(4f, 6f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("leg3", element => {
                    element.Translate = new Vector3(-2f, -6f, 4f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 0f, -6f),
                        Size = new Vector3(4f, 6f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("leg4", element => {
                    element.Translate = new Vector3(2f, -6f, 4f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, -6f),
                        Size = new Vector3(4f, 6f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                });
        }
    }
}
