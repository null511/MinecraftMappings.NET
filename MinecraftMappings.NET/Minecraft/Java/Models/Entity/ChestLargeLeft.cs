using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class ChestLargeLeft : JavaEntityModel
    {
        public ChestLargeLeft() : base("Chest (Large Left)")
        {
            AddVersion("chest_large_left", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("base_left", element => {
                    element.Part = "base_left";
                    element.Translate = new Vector3(-16f, -14f, 8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement("base_left_rotation") {
                        Translate = new Vector3(0f, 7f, 0f),
                        RotationAngleX = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(0f, -3f, -7f),
                                Size = new Vector3(15f, 10f, 14f),
                                UV = new Vector2(0f, 19f),
                            }
                        }
                    });
                })
                .AddElement("lid_left", element => {
                    element.Part = "lid_left";
                    element.Translate = new Vector3(-16f, -5f, 7f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement("lid_left_rotation") {
                        Translate = new Vector3(0f, 7f, 0f),
                        RotationAngleX = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(0f, -7f, -7f),
                                Size = new Vector3(15f, 5f, 14f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                })
                .AddElement("knob_left", element => {
                    element.Part = "knob_left";
                    element.Translate = new Vector3(-16f, -6f, 8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement("knob_left_rotation") {
                        Translate = new Vector3(0f, 7f, 0f),
                        RotationAngleX = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(0f, -4f, 7f),
                                Size = new Vector3(1f, 4f, 1f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                });
        }
    }
}
