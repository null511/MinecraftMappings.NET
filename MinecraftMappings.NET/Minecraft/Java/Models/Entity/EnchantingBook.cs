using MinecraftMappings.Internal.Models.Entity;
using SharpDX;
using System.Collections.Generic;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class EnchantingBook : JavaEntityModel
    {
        public EnchantingBook() : base("Enchanting Book")
        {
            AddVersion("enchanting_book", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("cover_left", element => {
                    element.Part = "cover_left";
                    element.Translate = new Vector3(-7f, -5f, 0);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "cover_left_rotation",
                        Translate = new Vector3(4f, 5f, 0f),
                        RotationAngleZ = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-3f, -5f, 0f),
                                Size = new Vector3(6f, 10f, 0f),
                                UV = new Vector2(16f, 0f),
                            },
                        },
                    });
                })
                .AddElement("cover_right", element => {
                    element.Part = "cover_right";
                    element.Translate = new Vector3(7f, -5f, 0);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "cover_right_rotation",
                        Translate = new Vector3(-4f, 5f, 0f),
                        RotationAngleZ = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-3f, -5f, 0f),
                                Size = new Vector3(6f, 10f, 0f),
                            },
                        },
                    });
                })
                .AddElement("book_spine", element => {
                    element.Part = "book_spine";
                    element.Translate = new Vector3(0f, -5f, 0);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "spine_rotation",
                        Translate = new Vector3(0f, 5f, 0f),
                        RotationAngleX = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -5f, 0f),
                                Size = new Vector3(2f, 10f, 0f),
                                UV = new Vector2(12f, 0f),
                            },
                        },
                    });
                })
                .AddElement("pages_left", element => {
                    element.Part = "pages_left";
                    element.Translate = new Vector3(-5f, -5f, 1.075f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "page_left_rotation",
                        Translate = new Vector3(2.5f, 5f, -0.6f),
                        RotationAngleZ = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-2.5f, -4f, -0.5f),
                                Size = new Vector3(5f, 8f, 1f),
                                UV = new Vector2(12f, 10f),
                            },
                        },
                    });
                })
                .AddElement("pages_right", element => {
                    element.Part = "pages_right";
                    element.Translate = new Vector3(0f, -5f, 0.125f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "page_right_rotation",
                        Translate = new Vector3(-2.5f, 5f, -0.6f),
                        RotationAngleY = -180,
                        RotationAngleZ = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-2.5f, -4f, -0.5f),
                                Size = new Vector3(5f, 8f, 1f),
                                UV = new Vector2(0f, 10f),
                            },
                        },
                    });
                })
                .AddElement("flipping_page_left", element => {
                    element.Part = "flipping_page_left";
                    element.Translate = new Vector3(-5f, -5f, 2.075f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "flip_left_rotation",
                        Translate = new Vector3(2.5f, 5f, -2.1f),
                        RotationAngleZ = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-2.5f, -4f, 0f),
                                Size = new Vector3(5f, 8f, 0f),
                                UV = new Vector2(24f, 10f),
                            },
                        },
                    });
                })
                .AddElement("flipping_page_right", element => {
                    element.Part = "flipping_page_right";
                    element.Translate = new Vector3(0f, -5f, 2.125f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "flip_right_rotation",
                        Translate = new Vector3(-2.5f, 5f, -2.1f),
                        RotationAngleY = -180,
                        RotationAngleZ = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-2.5f, -4f, 0f),
                                Size = new Vector3(5f, 8f, 0f),
                                UV = new Vector2(24f, 10f),
                            },
                        },
                    });
                });
        }
    }
}
