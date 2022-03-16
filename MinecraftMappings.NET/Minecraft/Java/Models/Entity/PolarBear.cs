using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class PolarBear : JavaEntityModel
    {
        public PolarBear() : base("Polar Bear")
        {
            AddVersion("polarbear", "1.0.0")
                .WithTextureSize(128, 64)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -14f, 16f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3.5f, 10f, -19f),
                        Size = new Vector3(7f, 7f, 7f),
                        UV = Vector2.Zero,
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 10f, -22f),
                        Size = new Vector3(5f, 3f, 3f),
                        UV = new Vector2(0f, 44f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4.5f, 16f, -17f),
                        Size = new Vector3(2f, 2f, 1f),
                        UV = new Vector2(26f, 0f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(2.5f, 16f, -17f),
                        Size = new Vector3(2f, 2f, 1f),
                        UV = new Vector2(26f, 0f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(-2f, -15f, -12f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "rotation",
                        Translate = new Vector3(0f, 15f, 12f),
                        RotationAngleX = -90,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Submodels = {
                            new EntityElement {
                                Id = "body_sub_1",
                                InvertAxisX = true,
                                InvertAxisY = true,

                                Boxes = {
                                    new EntityElementCube {
                                        Position = new Vector3(-7f, -1f, -7f),
                                        Size = new Vector3(14f, 14f, 11f),
                                        UV = new Vector2(0f, 19f),
                                    },
                                    new EntityElementCube {
                                        Position = new Vector3(-6f, 13f, -7f),
                                        Size = new Vector3(12f, 12f, 10f),
                                        UV = new Vector2(39f, 0f),
                                    },
                                },
                            },
                        },
                    });
                })
                .AddElement("leg1", element => {
                    element.Part = "leg1";
                    element.Translate = new Vector3(4.5f, -10f, -6f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-6.5f, 0f, 4f),
                        Size = new Vector3(4f, 10f, 8f),
                        UV = new Vector2(50f, 22f),
                    });
                })
                .AddElement("leg2", element => {
                    element.Part = "leg2";
                    element.Translate = new Vector3(-4.5f, -10f, -6f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(2.5f, 0f, 4f),
                        Size = new Vector3(4f, 10f, 8f),
                        UV = new Vector2(50f, 22f),
                    });
                })
                .AddElement("leg3", element => {
                    element.Part = "leg3";
                    element.Translate = new Vector3(3.5f, -10f, 8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5.5f, 0f, -10f),
                        Size = new Vector3(4f, 10f, 6f),
                        UV = new Vector2(50f, 40f),
                    });
                })
                .AddElement("leg4", element => {
                    element.Part = "leg4";
                    element.Translate = new Vector3(-3.5f, -10f, 8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1.5f, 0f, -10f),
                        Size = new Vector3(4f, 10f, 6f),
                        UV = new Vector2(50f, 40f),
                    });
                });
        }
    }
}
