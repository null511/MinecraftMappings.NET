using MinecraftMappings.Internal.Models.Entity;
using SharpDX;
using System.Collections.Generic;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Witch : JavaEntityModel
    {
        public Witch() : base("Witch")
        {
            AddVersion("witch", "1.4.2");

            AddVersion("witch", "1.14")
                .WithTextureSize(64, 128)
                .AddElement("head", element => {
                    element.Position = new Vector3(-4f, 24f, -4f);
                    element.Size = new Vector3(8f, 10f, 8f);
                    element.UV = Vector2.Zero;
                    element.RotationOrigin = new Vector3(0f, 24f, 0f);
                })
                .AddElement("headwear", element => {
                    element.Position = new Vector3(-5f, 32.05f, -5f);
                    element.Size = new Vector3(10f, 2f, 10f);
                    element.UV = new Vector2(0f, 64f);
                    element.RotationOrigin = new Vector3(0f, 24f, 0f);

                    element.Elements = new List<EntityElement> {
                        new EntityElement {
                            Name = "hat2",
                            Position = new Vector3(-3.75f, 34.05f, -3f),
                            Size = new Vector3(7f, 4f, 7f),
                            UV = new Vector2(0f, 76f),
                            RotationOrigin = new Vector3(3.25f, 38.05f, -3f),
                            RotationAngleX = 3f,
                            RotationAngleZ = 1.5f,

                            Elements = new List<EntityElement> {
                                new EntityElement {
                                    Name = "hat3",
                                    Position = new Vector3(-2.5f, 38.05f, -1f),
                                    Size = new Vector3(4f, 4f, 4f),
                                    UV = new Vector2(0f, 87f),
                                    RotationOrigin = new Vector3(1.5f, 42.05f, -1f),
                                    RotationAngleX = 6f,
                                    RotationAngleZ = 3f,

                                    Elements = new List<EntityElement> {
                                        new EntityElement {
                                            Name = "hat4",
                                            Position = new Vector3(-1.25f, 42.05f, 1f),
                                            Size = new Vector3(1f, 2f, 1f),
                                            UV = new Vector2(0f, 95f),
                                            RotationOrigin = new Vector3(-0.25f, 44.05f, 1f),
                                            RotationAngleX = 12f,
                                            RotationAngleZ = 6f,
                                            Inflate = 0.25f,
                                        },
                                    }
                                },
                            }
                        },
                    };
                })
                .AddElement("nose", element => {
                    element.Position = new Vector3(-1f, 23f, -6f);
                    element.Size = new Vector3(2f, 4f, 2f);
                    element.UV = new Vector2(24f, 0f);
                    element.RotationOrigin = new Vector3(0f, 26f, 0f);
                })
                .AddElement("mole", element => {
                    element.Position = new Vector3(-1f, 24f, -6.75f);
                    element.Size = new Vector3(1f, 1f, 1f);
                    element.UV = new Vector2(0f, 0f);
                    element.RotationOrigin = new Vector3(0f, 28f, 0f);
                    element.Inflate = -0.25f;
                })
                .AddElement("body", element => {
                    element.Position = new Vector3(-4f, 12f, -3f);
                    element.Size = new Vector3(8f, 12f, 6f);
                    element.UV = new Vector2(16f, 20f);
                    element.RotationOrigin = new Vector3(0f, 24f, 0f);
                })
                .AddElement("bodywear", element => {
                    element.Position = new Vector3(-4f, 6f, -3f);
                    element.Size = new Vector3(8f, 18f, 6f);
                    element.UV = new Vector2(0f, 38f);
                    element.RotationOrigin = new Vector3(0f, 24f, 0f);
                    element.Inflate = 0.5f;
                })
                .AddElement("left_leg", element => {
                    element.Position = new Vector3(-4f, 0f, -2f);
                    element.Size = new Vector3(4f, 12f, 4f);
                    element.UV = new Vector2(0f, 22f);
                    element.RotationOrigin = new Vector3(2f, 12f, 0f);
                })
                .AddElement("right_leg", element => {
                    element.Position = new Vector3(0f, 0f, -2f);
                    element.Size = new Vector3(4f, 12f, 4f);
                    element.UV = new Vector2(0f, 22f);
                    element.RotationOrigin = new Vector3(-2f, 12f, 0f);
                })
                .AddElement("right_arm", element => {
                    element.Position = new Vector3(4f, 14.5f, -1.65f);
                    element.Size = new Vector3(4f, 8f, 4f);
                    element.UV = new Vector2(44f, 22f);
                    element.RotationOrigin = new Vector3(0f, 22.5f, 0.35f);
                    element.RotationAngleX = 43f;
                })
                .AddElement("right_arm", element => {
                    element.Position = new Vector3(-8f, 14.5f, -1.65f);
                    element.Size = new Vector3(4f, 8f, 4f);
                    element.UV = new Vector2(44f, 22f);
                    element.RotationOrigin = new Vector3(0f, 22.5f, 0.35f);
                    element.RotationAngleX = 43f;
                })
                .AddElement("arms_crossed", element => {
                    element.Position = new Vector3(-4f, 14.5f, -1.65f);
                    element.Size = new Vector3(8f, 4f, 4f);
                    element.UV = new Vector2(40f, 38f);
                    element.RotationOrigin = new Vector3(0f, 22.5f, 0.35f);
                    element.RotationAngleX = 43f;
                });
        }
    }
}
