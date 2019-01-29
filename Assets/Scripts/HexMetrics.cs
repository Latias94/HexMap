using UnityEngine;

public static class HexMetrics
{
    public const float OUTER_RADIUS = 10f;
    public const float INNER_RADIUS = OUTER_RADIUS * 0.866025404f;

    public static Vector3[] corners =
    {
        new Vector3(0f, 0f, OUTER_RADIUS),
        new Vector3(INNER_RADIUS, 0f, 0.5f * OUTER_RADIUS),
        new Vector3(INNER_RADIUS, 0f, -0.5f * OUTER_RADIUS),
        new Vector3(0f, 0f, -OUTER_RADIUS),
        new Vector3(-INNER_RADIUS, 0f, -0.5f * OUTER_RADIUS),
        new Vector3(-INNER_RADIUS, 0f, 0.5f * OUTER_RADIUS),
        new Vector3(0f, 0f, OUTER_RADIUS)
    };
}