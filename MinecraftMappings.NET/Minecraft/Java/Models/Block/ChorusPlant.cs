﻿using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ChorusPlant : JavaBlockModel
    {
        public ChorusPlant() : base("Chorus Plant")
        {
            AddVersion("chorus_plant", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("texture", "block/chorus_plant")
                .AddTexture("inside", "block/chorus_plant")
                .AddElement(element => {
                    element.From = new Vector3(2f, 14f, 2f);
                    element.To = new Vector3(14f, 16f, 14f);
                    element.FaceUp = new ModelFace("#texture", UVMap(2f, 2f, 14f, 14f));
                    element.FaceNorth = new ModelFace("#texture", UVMap(2f, 0f, 14f, 2f));
                    element.FaceSouth = new ModelFace("#texture", UVMap(2f, 0f, 14f, 2f));
                    element.FaceWest = new ModelFace("#texture", UVMap(2f, 0f, 14f, 2f));
                    element.FaceEast = new ModelFace("#texture", UVMap(2f, 0f, 14f, 2f));
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 2f, 2f);
                    element.To = new Vector3(2f, 14f, 14f);
                    element.FaceDown = new ModelFace("#texture", UVMap(16f, 14f, 14f, 2f));
                    element.FaceUp = new ModelFace("#texture", UVMap(0f, 2f, 2f, 14f));
                    element.FaceNorth = new ModelFace("#texture", UVMap(14f, 2f, 16f, 14f));
                    element.FaceSouth = new ModelFace("#texture", UVMap(0f, 2f, 2f, 14f));
                    element.FaceWest = new ModelFace("#texture", UVMap(2f, 2f, 14f, 14f));
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 2f, 0f);
                    element.To = new Vector3(14f, 14f, 2f);
                    element.FaceDown = new ModelFace("#texture", UVMap(14f, 2f, 2f, 0f));
                    element.FaceUp = new ModelFace("#texture", UVMap(2f, 0f, 14f, 2f));
                    element.FaceNorth = new ModelFace("#texture", UVMap(2f, 2f, 14f, 14f));
                    element.FaceWest = new ModelFace("#texture", UVMap(0f, 2f, 2f, 14f));
                    element.FaceEast = new ModelFace("#texture", UVMap(14f, 2f, 16f, 14f));
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 2f, 14f);
                    element.To = new Vector3(14f, 14f, 16f);
                    element.FaceDown = new ModelFace("#texture", UVMap(14f, 16f, 2f, 14f));
                    element.FaceUp = new ModelFace("#texture", UVMap(2f, 14f, 14f, 16f));
                    element.FaceSouth = new ModelFace("#texture", UVMap(2f, 2f, 14f, 14f));
                    element.FaceWest = new ModelFace("#texture", UVMap(14f, 2f, 16f, 14f));
                    element.FaceEast = new ModelFace("#texture", UVMap(0f, 2f, 2f, 14f));
                })
                .AddElement(element => {
                    element.From = new Vector3(14f, 2f, 2f);
                    element.To = new Vector3(16f, 14f, 14f);
                    element.FaceDown = new ModelFace("#texture", UVMap(2f, 14f, 0f, 2f));
                    element.FaceUp = new ModelFace("#texture", UVMap(14f, 2f, 16f, 14f));
                    element.FaceNorth = new ModelFace("#texture", UVMap(0f, 2f, 2f, 14f));
                    element.FaceSouth = new ModelFace("#texture", UVMap(14f, 2f, 16f, 14f));
                    element.FaceEast = new ModelFace("#texture", UVMap(2f, 2f, 14f, 14f));
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 0f, 2f);
                    element.To = new Vector3(14f, 2f, 14f);
                    element.FaceDown = new ModelFace("#texture", UVMap(14f, 14f, 2f, 2f));
                    element.FaceNorth = new ModelFace("#texture", UVMap(2f, 14f, 14f, 16f));
                    element.FaceSouth = new ModelFace("#texture", UVMap(2f, 14f, 14f, 16f));
                    element.FaceWest = new ModelFace("#texture", UVMap(2f, 14f, 14f, 16f));
                    element.FaceEast = new ModelFace("#texture", UVMap(2f, 14f, 14f, 16f));
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 2f, 2f);
                    element.To = new Vector3(14f, 14f, 14f);
                    element.FaceDown = new ModelFace("#inside", UVMap(14f, 14f, 2f, 2f));
                    element.FaceUp = new ModelFace("#inside", UVMap(2f, 2f, 14f, 14f));
                    element.FaceNorth = new ModelFace("#inside", UVMap(2f, 2f, 14f, 14f));
                    element.FaceSouth = new ModelFace("#inside", UVMap(2f, 2f, 14f, 14f));
                    element.FaceWest = new ModelFace("#inside", UVMap(2f, 2f, 14f, 14f));
                    element.FaceEast = new ModelFace("#inside", UVMap(2f, 2f, 14f, 14f));
                });
        }
    }
}
