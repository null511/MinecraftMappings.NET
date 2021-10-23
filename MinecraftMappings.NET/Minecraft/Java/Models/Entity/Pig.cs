using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Pig : JavaEntityModel
    {
        public Pig() : base("Pig")
        {
            AddVersion("pig", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -13f, -2f);

                    element.Submodels.Add(new EntityElement {
                        Name = "rotation",
                        Translate = new Vector3(0f, 13f, 2f),
                        RotationAngleX = -90,

                        Submodels = {
                            new EntityElement {
                                Name = "body_sub_1",

                                Cubes = {
                                    new EntityElementCube {
                                        Position = new Vector3(-5f, -6f, -7f),
                                        Size = new Vector3(10f, 16f, 8f),
                                        UV = new Vector2(28f, 8f),
                                    },
                                },
                            },
                        },
                    });
                })
                .AddElement("head", element => {
                    element.Translate = new Vector3(0f, -12f, 6f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 8f, -14f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = Vector2.Zero,
                    });
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 9f, -15f),
                        Size = new Vector3(4f, 3f, 1f),
                        UV = new Vector2(16f, 16f),
                    });
                })
                .AddElement("leg1", element => {
                    element.Translate = new Vector3(3f, -6f, -7f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 0f, 5f),
                        Size = new Vector3(4f, 6f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("leg2", element => {
                    element.Translate = new Vector3(-3f, -6f, -7f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 0f, 5f),
                        Size = new Vector3(4f, 6f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("leg3", element => {
                    element.Translate = new Vector3(3f, -6f, 5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 0f, -7f),
                        Size = new Vector3(4f, 6f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("leg4", element => {
                    element.Translate = new Vector3(-3f, -6f, 5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 0f, -7f),
                        Size = new Vector3(4f, 6f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                });
        }
    }
}
