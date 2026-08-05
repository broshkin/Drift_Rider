# Drift Rider

An arcade drift game. You drive, things chase you, and you collect loot while staying alive.

Released on Yandex Games and since taken down from the platform, so there is nothing to play
here any more. The code is what is left.

## What is in it

**Enemies chase on a NavMesh.** `NavMeshAgentMoving.cs` drives the pursuers and `PointToEnemy.cs` puts an indicator on screen so the player knows where the pressure is coming from while looking forward.

**Loot boxes and pickups.** `LootBoxSystem.cs` with `CatchLoot.cs` and `CatchHeal.cs` for the pickup side.

**Health with real consequences.** `PlayerHealth.cs` and `PunchPlayer.cs` handle taking hits from the cars that catch you.

**A rear view camera.** `RearCamera.cs`. It exists because it is genuinely hard to judge a chase without it.

**`CheckWheelOnGround.cs`** gates drifting and scoring on whether the car is actually touching the road, which stopped players from farming score mid air.

## Built with

Unity, C#. The car handling itself is the PROMETEO Car Controller from the asset store. I did not write the vehicle physics and I would rather say so than let someone assume otherwise. My code is the game around it: chase, loot, health, UI, pause and settings.

## Reading the code

My own code is under `Assets/Scripts/`. `Assets/PROMETEO - Car Controller/` is the store asset.

## When this was made

2024. A small published title rather than a portfolio piece. It shipped, ran on the platform for
a while, and is no longer listed there.

## What I would do differently today

**The pickups would be one component.** `CatchLoot` and `CatchHeal` are two near identical
MonoBehaviours that differ in what they add to the player. That is a single component with a
configurable effect.

**`Assets/Scripts/` would have structure.** Everything sits flat in one folder except the buttons.
At eighteen files it is survivable. At sixty it would not be.

If you want to see how I write now, look at
[FigureSpider](https://github.com/broshkin/FigureSpider), which is from 2026.
