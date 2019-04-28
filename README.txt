CMPM 163 S2019
Game Graphics & Real-time Rendering 
Jeanette Mui, jemui@ucsc.edu

Homework 1
Part A can run from https://cowsgooom.itch.io/unity-homework-1-part-a?secret=LHeD63swBmFEfwFmtuHDC576A
Github Repo - https://github.com/jemui/CMPM-163-Homework-1

Part A. Design a 3D scene
Files: 
Rotate.cs
RotateSpotlight.cs
Move.cs
MovePointLight.cs
MoveSphere.cs
Phong.shader
Phong_lighting.shader
VertexRotation.shader

Part A consists of a 3D scene with 3 3D objects and 3 lights
which are all moving or rotating. One object uses a Phong shader, another uses a textured shader 
that reacts to lighting, and the third contains a shader that converts the normal value to a color.

The 3 lights used were a directional light, point light, and spotlight. 
The spotlight appears on the plane as a soft shadow on the plane when the directional light darkens
the screen. The point light affects the lighting on the sphere.

Artic fox poly is from here - 
https://poly.google.com/view/dK08uQ8-Zm9

Part B. Image Processing
Files: 
Blur.shader
Mouse_Blur_Darken.cs 

Part B involves creating an image processing shader that takes in a keyboard input to adjust 
the blur and difference effect of a textured cube.

Use the A/S key to increase/decrease blurriness (Range is -1.0(see original texture) to 50.0) 
Use the Z/X key to increase/decrease the difference effect (Range is 0.0 to 1.0)
 
Part C 
Files: 
PingPong_CellularAutomata.cs
RenderToTexture_CA.shader
OutputTexture.shader

Part C is a multi-color game of life. Clicking the cube will restart the state. 

Part D
The pdf will be in the Git repository. The effect is from Ori and the Blind Forest, which has a soft glowing 
gradient effect, with motion blur and a bright blue trail following the player character, Ori.