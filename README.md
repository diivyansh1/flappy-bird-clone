<h1>
 FLAPPY BIRD CLONE
</h1>
<h2>
 Script Breakdown
</h2>
Player.cs — gravity (-9.8) and flap strength system with InvokeRepeating sprite animation at 0.15s intervals. Supports keyboard, mouse, and touch input.

pipes.cs — pipes move at constant speed (5 units/s) and self-destroy when they reach the left edge (leftEdge via Camera.ScreenToWorldPoint).

spawner.cs — procedural pipe spawning at configurable rate with Random.Range for vertical position variation.

parallax.cs — infinite background scroll via MeshRenderer mainTextureOffset, creating depth illusion.

GameManager.cs — score tracking with Scoring trigger zones and GameOver state management.

<h2>
 Demo & Pictures
</h2>


https://github.com/user-attachments/assets/50bba787-f958-4bce-9f73-afae2566eea6


<img width="1013" height="444" alt="image" src="https://github.com/user-attachments/assets/184c4a31-9559-4792-a4be-5e597a9c03d4" /><img width="802" height="445" alt="image" src="https://github.com/user-attachments/assets/593088b2-fad9-455f-ba71-391a542054c2" />

