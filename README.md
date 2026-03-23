# MyGoodDiary

Proyecto de aplicación multiplataforma desarrollado con **.NET MAUI**.  
Permite llevar un diario personal con sincronización local y funcionalidades básicas de gestión de entradas.

## Requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- IDE recomendado: Visual Studio Code con soporte para MAUI
- Android SDK y emuladores configurados si se quiere probar en Android
- (Opcional) Mac con Xcode si se desea compilar para iOS

## Comandos esenciales de MAUI

### Crear un proyecto MAUI
```bash
- dotnet new maui -n MyGoodDiary

- dotnet restore(Restaurar dependencias)

- dotnet build(Compilar la aplicación)

- dotnet build -t:Run -f net10.0-android(Ejecutar la aplicación en Android)

- dotnet build -t:Run -f net10.0-windows10.0.22621.0(Ejecutar la aplicación en Windows)

- dotnet clean(Limpiar la solución)


- Actualizar paquetes NuGet
dotnet nuget locals all --clear
dotnet restore


- Ejecutar Hot Reload en Android
dotnet watch -f net10.0-android run (Depuración rápida y Hot Reload(Hot Reload permite ver cambios en la UI sin reiniciar la app.))

- Ejecutar Hot Reload en Windows
dotnet watch -f net10.0-windows10.0.22621.0 run


- dotnet watch --no-launch-profile run(Reiniciar la app mientras se mantiene el estado)


- adb logcat -s MyGoodDiary:V(Ver logs en Android)






Emuladores y dispositivos
Android: AVD Manager para crear emuladores, o conectar dispositivo con USB + depuración activada.
iOS: Simulador Xcode (Cmd + Shift + H para reset), o dispositivo conectado con provisionamiento correcto.

- Comando rápido para ver dispositivos Android conectados:
```bash
adb devices

- Comando rápido para ver simuladores iOS:
```bash

xcrun simctl list devices









Estructura básica del proyecto
/MyGoodDiary
│
├─ Platforms/       # Configuraciones específicas de cada plataforma
├─ Resources/       # Imágenes, fuentes, estilos
├─ Views/           # Páginas y layouts
├─ ViewModels/      # Lógica de presentación
├─ Models/          # Modelos de datos
├─ App.xaml         # Configuración global de la aplicación
└─ MainPage.xaml    # Página principal
Recursos útiles
Documentación oficial MAUI: https://learn.microsoft.com/dotnet/maui/
Tutoriales y ejemplos: https://github.com/dotnet/maui-samples
Tips de depuración y Hot Reload: https://learn.microsoft.com/dotnet/maui/debug