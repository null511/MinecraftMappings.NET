using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class WanderingTrader : JavaEntityModel
    {
        public WanderingTrader() : base("Wandering Trader")
        {
            AddVersion("wandering_trader", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("head", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 24f, -4f),
                        Size = new Vector3(8f, 10f, 8f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("headwear", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 24f, -4f),
                        Size = new Vector3(8f, 10f, 8f),
                        UV = new Vector2(32f, 0f),
                        Inflate = 0.5f,
                    });
                })
                .AddElement("headwear2", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Submodels.Add(new EntityElement {
                        Name = "rotation",
                        Translate = new Vector3(0f, 24f, 0f),
                        RotationAngleX = 90,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-8f, -8f, -6f),
                                Size = new Vector3(16f, 16f, 1f),
                                UV = new Vector2(30f, 47f),
                            },
                        },
                    });
                })
                .AddElement("nose", element => {
                    element.Translate = new Vector3(0f, -26f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 23f, -6f),
                        Size = new Vector3(2f, 4f, 2f),
                        UV = new Vector2(24f, 0f),
                    });
                })
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 12f, -3f),
                        Size = new Vector3(8f, 12f, 6f),
                        UV = new Vector2(16f, 20f),
                    });
                })
                .AddElement("bodywear", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 6f, -3f),
                        Size = new Vector3(8f, 18f, 6f),
                        UV = new Vector2(0f, 38f),
                        Inflate = 0.25f,
                    });
                })
                .AddElement("arms", element => {
                    element.Translate = new Vector3(0f, -20.5f, -0.3f);

                    element.Submodels.Add(new EntityElement {
                        Name = "arms_rotation",
                        Translate = new Vector3(0f, 22.5f, 0.35f),
                        RotationAngleX = 43f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(4f, -8f, -2.05f),
                                Size = new Vector3(4f, 8f, 4f),
                                UV = new Vector2(44f, 22f),
                            },
                            new EntityElementCube {
                                Position = new Vector3(-4f, -8f, -2.05f),
                                Size = new Vector3(8f, 4f, 4f),
                                UV = new Vector2(40f, 38f),
                            },
                        },

                        Submodels = {
                            new EntityElement {
                                Name = "arms_flipped",
                                Translate = new Vector3(0f, -24f, 0f),
                                MirrorTexU = true,

                                Cubes = {
                                    new EntityElementCube {
                                        Position = new Vector3(-8f, 16f, -2.05f),
                                        Size = new Vector3(4f, 8f, 4f),
                                        UV = new Vector2(44f, 22f),
                                    },
                                },
                            },
                        }
                    });
                })
                .AddElement("right_leg", element => {
                    element.Translate = new Vector3(-2f, -12f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 0f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 22f),
                    });
                })
                .AddElement("left_leg", element => {
                    element.Translate = new Vector3(2f, -12f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 22f),
                    });
                });
        }
    }
}
