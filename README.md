# UsbEject Microsoft.Extensions.Logging Adapter

Works with [UsbEject](https://github.com/CHDKUtil/UsbEject).

## Usage

```csharp
LoggerAdapter logger = new LoggerAdapter(loggerFactory);
using (VolumeDeviceClass volumes = new VolumeDeviceClass(logger))
{
  Volume volume = volumes.SingleOrDefault(v => ejectDrive.Equals(v.LogicalDrive));
  volume?.Eject(false);
}
```

## License

* MIT License
