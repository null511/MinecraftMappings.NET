using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class ChestLargeRight : JavaEntityModel
    {
        public ChestLargeRight() : base("Chest (Large Right)")
        {
            AddVersion("chest_large_right", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("base_right", element => {
                    element.Part = "base_right";
                    element.Translate = new Vector3(0f, -14f, 8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement("base_right_rotation") {
                        Translate = new Vector3(0f, 7f, 0f),
                        RotationAngleX = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-15f, -3f, -7f),
                                Size = new Vector3(15f, 10f, 14f),
                                UV = new Vector2(0f, 19f),
                            }
                        }
                    });
                })
                .AddElement("lid_right", element => {
                    element.Part = "lid_right";
                    element.Translate = new Vector3(0f, -5f, 7f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement("lid_right_rotation") {
                        Translate = new Vector3(0f, 7f, 0f),
                        RotationAngleX = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-15f, -7f, -7f),
                                Size = new Vector3(15f, 5f, 14f),
                                UV = new Vector2(0f, 0f),
                            },
                        },
                    });
                })
                .AddElement("knob_right", element => {
                    element.Part = "knob_right";
                    element.Translate = new Vector3(0f, -6f, 8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement("knob_right_rotation") {
                        Translate = new Vector3(0f, 7f, 0f),
                        RotationAngleX = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -4f, 7f),
                                Size = new Vector3(1f, 4f, 1f),
                                UV = new Vector2(0f, 0f),
                            },
                        },
                    });
                });
        }
    }
}
