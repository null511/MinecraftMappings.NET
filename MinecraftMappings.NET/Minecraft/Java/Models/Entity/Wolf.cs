using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Wolf : JavaEntityModel
    {
        public Wolf() : base("Wolf")
        {
            AddVersion("wolf", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("head", element => {
                    element.Translate = new Vector3(-1f, -10.5f, 7f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 7.5f, -9f),
                        Size = new Vector3(6f, 6f, 4f),
                        UV = Vector2.Zero,
                    });
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 13.5f, -7f),
                        Size = new Vector3(2f, 2f, 1f),
                        UV = new Vector2(16f, 14f),
                    });
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 13.5f, -7f),
                        Size = new Vector3(2f, 2f, 1f),
                        UV = new Vector2(16f, 14f),
                    });
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 7.52f, -12f),
                        Size = new Vector3(3f, 3f, 4f),
                        UV = new Vector2(0, 10f),
                    });
                })
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -10f, -2f);

                    element.Submodels.Add(new EntityElement {
                        Name = "body_rotation",
                        Translate = new Vector3(0f, 10f, 2f),
                        RotationAngleX = -90,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-3f, -7f, -3f),
                                Size = new Vector3(6f, 9f, 6f),
                                UV = new Vector2(18f, 14f),
                            },
                        },
                    });
                })
                .AddElement("mane", element => {
                    element.Translate = new Vector3(-1f, -10f, -2f);

                    element.Submodels.Add(new EntityElement {
                        Name = "mane_rotation",
                        Translate = new Vector3(0f, 7.5f, -0.5f),
                        RotationAngleX = -90,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-4f, -0.5f, -0.5f),
                                Size = new Vector3(8f, 6f, 7f),
                                UV = new Vector2(21f, 0f),
                            },
                        },
                    });
                })
                .AddElement("leg1", element => {
                    element.Translate = new Vector3(-2.5f, -8f, -7f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(0.5f, 0f, 6f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 18f),
                    });
                })
                .AddElement("leg2", element => {
                    element.Translate = new Vector3(0.5f, -8f, -7f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 0f, 6f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 18f),
                    });
                })
                .AddElement("leg3", element => {
                    element.Translate = new Vector3(3f, -6f, 5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(0.5f, 0f, -5f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 18f),
                    });
                })
                .AddElement("leg4", element => {
                    element.Translate = new Vector3(0.5f, -8f, 4f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 0f, -5f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(0f, 18f),
                    });
                })
                .AddElement("tail", element => {
                    element.Translate = new Vector3(-1f, -12f, -10f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 4f, 9f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = new Vector2(9f, 18f),
                    });
                });
        }
    }
}
