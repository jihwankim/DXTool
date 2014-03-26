#pragma once

extern "C" {

	__declspec(dllexport) void InitD3D(HWND hWnd);
	__declspec(dllexport) void InitGeometry();
	__declspec(dllexport) void Cleanup();
	__declspec(dllexport) bool BeginScene();
	__declspec(dllexport) void EndScene();

	__declspec(dllexport) void SetupLights();
	__declspec(dllexport) void SetupCamera(float ex, float ey, float ez, float lx, float ly, float lz, float ux, float uy, float uz);
	__declspec(dllexport) void SetupMatrices(float tx, float ty, float tz, float rx, float ry, float rz);

	__declspec(dllexport) void DrawCylinder();
};
