using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class SnowGolem : JavaEntityModel
    {
        public SnowGolem() : base("Snow Golem")
        {
            AddVersion("snow_golem", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -20f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 20f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = new Vector2(0f, 0f),
                        SizeAdd = -0.5f,
                    });
                })
                .AddElement("left_hand", element => {
                    element.Part = "left_hand";
                    element.Translate = new Vector3(4.5f, -18.75f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "left_hand_rotation",
                        Translate = new Vector3(-4f, 17.75f, 0f),
                        RotationAngleZ = 57,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-11.5f, -1f, -1f),
                                Size = new Vector3(12f, 2f, 2f),
                                UV = new Vector2(32f, 0f),
                                SizeAdd = -0.5f,
                            },
                        },
                    });
                })
                .AddElement("right_hand", element => {
                    element.Part = "right_hand";
                    element.Translate = new Vector3(-14.5f, -18.75f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "right_hand_flip",
                        Translate = new Vector3(9.5f, 17.75f, 0f),
                        RotationAngleY = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Submodels = {
                            new EntityElement {
                                Id = "right_hand_rotation",
                                Translate = new Vector3(5.5f, 0f, 0f),
                                RotationAngleZ = 57,
                                InvertAxisX = true,
                                InvertAxisY = true,

                                Boxes = {
                                    new EntityElementCube {
                                        Position = new Vector3(-11.5f, -1f, -1f),
                                        Size = new Vector3(12f, 2f, 2f),
                                        UV = new Vector2(32f, 0f),
                                        SizeAdd = -0.5f,
                                    },
                                },
                            },
                        },
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -11f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 11f, -5f),
                        Size = new Vector3(10f, 10f, 10f),
                        UV = new Vector2(0f, 16f),
                        SizeAdd = -0.5f,
                    });
                })
                .AddElement("body_bottom", element => {
                    element.Part = "body_bottom";
                    element.Translate = new Vector3(0f, 0f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 0f, -6f),
                        Size = new Vector3(12f, 12f, 12f),
                        UV = new Vector2(0f, 36f),
                        SizeAdd = -0.5f,
                    });
                });
        }
    }
}
