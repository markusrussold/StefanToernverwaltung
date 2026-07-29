# Deploy & Runtime Notes — Törnverwaltung

## Requirements

- Windows x86 (32-bit) process: the EXE targets **x86** because **Microsoft Jet OLEDB 4.0** is 32-bit only.
- .NET Framework **4.8**
- Jet provider / DAO / ADOX available (Access Database Engine 32-bit if Jet is missing)
- Writable application folder (MDB create/update, `Logs\`, `Backups\`)

## Files next to Verwaltung.exe

| File | Purpose |
|------|---------|
| `Toernverwaltung.mdb` | Main data |
| `Ausbildung.mdb` | Courses |
| `Export.mdb` | Import/export staging |
| `Logbuch.mdb` | Logbook |
| `Crewbesprechung.mdb` | Crew meetings |
| `Versicherung.mdb` | Insurance |
| `app.config` | Runtime config |
| `Microsoft.VisualBasic.PowerPacks.Vs.dll` | UI shapes (from `Resources\`) |
| `Logs\` | Created at runtime (`verwaltung-YYYYMMDD.log`) |
| `Backups\` | Automatic MDB backups before schema changes |

On first start, missing MDBs are created (or adopted from `ToernverwaltungNeu*.mdb`). Schema tables/columns are ensured from the typed DataSets.

## Signing

Release builds should be signed (`sign-output.ps1` PostBuild) so Smart App Control / Defender do not block the EXE.

## Smoke test

From the repo root (or after copying the Release output):

```powershell
powershell -NoProfile -File tools\smoke-test.ps1 -AppDir "bin\x86\Release"
```

## Architecture note

Runtime storage remains **Access/Jet**. New code should use `DbAccess` / `SafeData` / `AppLog` as the seam for a future engine (SQLite/LocalDB). A full DB engine migration is intentionally **not** included in this hardening pass.
