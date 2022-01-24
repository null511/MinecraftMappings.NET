using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Minecart : JavaEntityModel
    {
        public Minecart() : base("Minecart")
        {
            AddVersion("minecart", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("front", element => {
                    element.Translate = new Vector3(0f, -1f, -9f);

                    element.Submodels.Add(new EntityElement {
                        Name = "front2",
                        RotationAngleY = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-8f, 2f, 8f),
                                Size = new Vector3(16f, 8f, 2f),
                            },
                        },
                    });

                    element.Submodels.Add(new EntityElement {
                        Name = "back2",
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-8f, 2f, 8f),
                                Size = new Vector3(16f, 8f, 2f),
                            },
                        },
                    });

                    element.Submodels.Add(new EntityElement {
                        Name = "right2",
                        RotationAngleY = 90,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-8f, 2f, 6f),
                                Size = new Vector3(16f, 8f, 2f),
                            },
                        },
                    });

                    element.Submodels.Add(new EntityElement {
                        Name = "left2",
                        RotationAngleY = -90,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-8f, 2f, 6f),
                                Size = new Vector3(16f, 8f, 2f),
                            },
                        },
                    });

                    element.Submodels.Add(new EntityElement {
                        Name = "base",
                        RotationAngleY = 90,
                        RotationAngleZ = 90,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-10f, -8f, 0f),
                                Size = new Vector3(20f, 16f, 2f),
                                UV = new Vector2(0f, 10f),
                            },
                        },
                    });
                });
        }
    }
}
