using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class SheepWool : JavaEntityModel
    {
        public SheepWool() : base("Sheep Wool")
        {
            AddVersion("sheep_wool", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -19f, -2f);

                    element.Submodels.Add(new EntityElement("rotation") {
                        Translate = new Vector3(0f, 19f, 2f),
                        RotationAngleX = -90f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-4f, -6f, -7f),
                                Size = new Vector3(8f, 16f, 6f),
                                UV = new Vector2(28f, 8f),
                                Inflate = 1.75f,
                            },
                        },
                    });
                })
                .AddElement("head", element => {
                    element.Translate = new Vector3(0f, -18f, 8f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 16f, -12f),
                        Size = new Vector3(6f, 6f, 6f),
                        UV = new Vector2(0f, 0f),
                        Inflate = 0.6f,
                    });
                })
                .AddElement("leg1", element => {
                    element.Translate = new Vector3(-3f, -12f, -7f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 6f, 5f),
                        Size = new Vector3(4f, 6f, 4f),
                        UV = new Vector2(0f, 16f),
                        Inflate = 0.5f,
                    });
                })
                .AddElement("leg2", element => {
                    element.Translate = new Vector3(3f, -12f, -7f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 6f, 5f),
                        Size = new Vector3(4f, 6f, 4f),
                        UV = new Vector2(0f, 16f),
                        Inflate = 0.5f,
                    });
                })
                .AddElement("leg3", element => {
                    element.Translate = new Vector3(-3f, -12f, 5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 6f, -7f),
                        Size = new Vector3(4f, 6f, 4f),
                        UV = new Vector2(0f, 16f),
                        Inflate = 0.5f,
                    });
                })
                .AddElement("leg4", element => {
                    element.Translate = new Vector3(3f, -12f, 5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 6f, -7f),
                        Size = new Vector3(4f, 6f, 4f),
                        UV = new Vector2(0f, 16f),
                        Inflate = 0.5f,
                    });
                });
        }
    }
}
