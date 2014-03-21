#pragma once

extern "C" {

	__declspec(dllexport) void InitD3D(HWND hWnd);
	__declspec(dllexport) void InitGeometry();
	__declspec(dllexport) void Cleanup();
	__declspec(dllexport) bool BeginScene();
	__declspec(dllexport) void EndScene();

	__declspec(dllexport) void SetupLights();
	__declspec(dllexport) void SetupCamera();
	__declspec(dllexport) void SetupMatrices(float tx, float ty, float tz, float rx, float ry, float rz);

	__declspec(dllexport) void DrawCylinder();
};
