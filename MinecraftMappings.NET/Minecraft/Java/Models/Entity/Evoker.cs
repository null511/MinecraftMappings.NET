using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Evoker : JavaEntityModel
    {
        public Evoker() : base("Evoker")
        {
            AddVersion("evoker", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 24f, -4f),
                        Size = new Vector3(8f, 10f, 8f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("hat", element => {
                    element.Part = "hat";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("nose", element => {
                    element.Part = "nose";
                    element.Translate = new Vector3(0f, -26f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 23f, -6f),
                        Size = new Vector3(2f, 4f, 2f),
                        UV = new Vector2(24f, 0f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 12f, -3f),
                        Size = new Vector3(8f, 12f, 6f),
                        UV = new Vector2(16f, 20f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 6f, -3f),
                        Size = new Vector3(8f, 18f, 6f),
                        UV = new Vector2(0f, 38f),
                        SizeAdd = 0.25f,
                    });
                })
                //.AddElement("arms", element => {
                //    element.Part = "arms";
                //    element.Translate = new Vector3(0f, -20.5f, -0.3f);
                //    element.InvertAxisX = true;
                //    element.InvertAxisY = true;

                //    element.Submodels.Add(new EntityElement {
                //        Id = "arms_rotation",
                //        Translate = new Vector3(0f, 22.5f, 0.35f),
                //        RotationAngleX = 43f,
                //        InvertAxisX = true,
                //        InvertAxisY = true,

                //        Boxes = {
                //            new EntityElementCube {
                //                Position = new Vector3(4f, -8f, -2.05f),
                //                Size = new Vector3(4f, 8f, 4f),
                //                UV = new Vector2(44f, 22f),
                //            },
                //            new EntityElementCube {
                //                Position = new Vector3(-4f, -8f, -2.05f),
                //                Size = new Vector3(8f, 4f, 4f),
                //                UV = new Vector2(40f, 38f),
                //            },
                //        },

                //        Submodels = {
                //            new EntityElement {
                //                Id = "arms_flipped",
                //                Translate = new Vector3(0f, -24f, 0f),
                //                InvertAxisX = true,
                //                InvertAxisY = true,
                //                MirrorTexU = true,

                //                Boxes = {
                //                    new EntityElementCube {
                //                        Position = new Vector3(-8f, 16f, -2.05f),
                //                        Size = new Vector3(4f, 8f, 4f),
                //                        UV = new Vector2(44f, 22f),
                //                    },
                //                },
                //            },
                //        }
                //    });
                //})
                .AddElement("left_arm", element => {
                    element.Part = "left_arm";
                    element.Translate = new Vector3(5f, -22f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 12f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(40f, 46f),
                    });
                })
                .AddElement("right_arm", element => {
                    element.Part = "right_arm";
                    element.Translate = new Vector3(-5f, -22f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 12f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(40f, 46f),
                    });
                })
                .AddElement("left_leg", element => {
                    element.Part = "left_leg";
                    element.Translate = new Vector3(2f, -12f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 22f),
                    });
                })
                .AddElement("right_leg", element => {
                    element.Part = "right_leg";
                    element.Translate = new Vector3(-2f, -12f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 0f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 22f),
                    });
                });
        }
    }
}
