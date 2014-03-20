#pragma once

extern "C" {

	__declspec(dllexport) void InitD3D(HWND hWnd);
	__declspec(dllexport) void InitGeometry();
	__declspec(dllexport) void Render();
	__declspec(dllexport) void Cleanup();
};
