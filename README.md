# Törnverwaltung

Desktop-Anwendung zur Verwaltung von Segeltörns, Crews, Booten, Kursen und Logbüchern. Geschrieben in **VB.NET (WinForms)** für **.NET Framework 4.8 (x86)**.

**Aktuelle Version:** 13.02.06

Versionierung (`X.ZZ.Y`): Quelle ist `Helpers/AppVersion.vb`. Hochzählen mit:

```powershell
powershell -NoProfile -File tools\bump-version.ps1 -Part patch   # Bugfix (Y)
powershell -NoProfile -File tools\bump-version.ps1 -Part minor   # Feature (ZZ)
powershell -NoProfile -File tools\bump-version.ps1 -Part major   # DB-Breaking (X)
```

## Funktionsumfang

- **Törnverwaltung** — Törns anlegen, bearbeiten, Routen und Seemeilen erfassen
- **Crew & Adressen** — Crew-Mitglieder, Kontakte, Crewlisten und Crewbesprechungen
- **Bootverwaltung** — Bootsdaten, Charterunternehmen und Agenturen
- **Logbuch** — Tägliche Logbucheinträge, Wacheplan, Bordkassa
- **Kursverwaltung** — Kurstermine, Teilnehmer, Materialbestellungen, Kursstatistiken
- **Kalkulationen** — Törnkalkulation, Statistiken und Auswertungen
- **Import / Export** — Daten zwischen Instanzen austauschen (über Export-MDB)
- **Druckberichte** — Seemeilenbestätigungen, Logbuchblätter, Crew-Formulare u. v. m.
- **Versicherung** — Versicherungsdaten zu Personen und Booten

## Voraussetzungen

| Komponente | Details |
|------------|---------|
| **Betriebssystem** | Windows 10 / 11 (32- oder 64-Bit) |
| **Runtime** | .NET Framework 4.8 |
| **Datenbank** | Microsoft Jet OLEDB 4.0 (DAO/ADOX) — erfordert 32-Bit-Ausführung |
| **Optionale Abhängigkeit** | Acrobat Reader (für PDF-Berichte) |

> Die Anwendung wird als **x86-Prozess** ausgeführt, da der Jet-Provider nur als 32-Bit-Komponente verfügbar ist.

## Erstmaliger Start

Beim ersten Start erzeugt die Anwendung automatisch fehlende Access-Datenbanken neben der EXE:

| Datei | Inhalt |
|-------|--------|
| `Toernverwaltung.mdb` | Hauptdaten (Törns, Crew, Boote, Steuerdaten) |
| `Ausbildung.mdb` | Kursdaten |
| `Export.mdb` | Import-/Export-Staging |
| `Logbuch.mdb` | Logbucheinträge |
| `Crewbesprechung.mdb` | Crewbesprechungs-Protokolle |
| `Versicherung.mdb` | Versicherungsdaten |

Falls eine Datei `ToernverwaltungNeu.mdb` oder `ToernverwaltungNeu_be.mdb` vorhanden ist, wird sie als Hauptdatenbank übernommen. Tabellen und Spalten werden aus den typisierten DataSets ergänzt (Schema-Migration).

## Projektstruktur

```
├── Forms/          Alle WinForms (UI)
├── Printing/       Druckberichte (PrintDocument)
├── Data/           Typisierte DataSets (XSD / Designer)
├── Helpers/        Infrastruktur-Module
│   ├── AppLog.vb             Dateibasiertes Logging (Logs\)
│   ├── AppSettings.vb        Gehärtete Registry-Zugriffe
│   ├── ApplicationEvents.vb  Startup + globale Fehlerbehandlung
│   ├── DatabaseBootstrap.vb  MDB-Erzeugung, Schema-Migration, Backups
│   ├── DbAccess.vb           Jet-Check, Lock-Retry, parametrisierte Queries
│   ├── FormUi.vb             Fensterpositionierung
│   ├── InputValidation.vb    MaskedTextBox-/Datumsvalidierung
│   ├── PathGuard.vb          Sichere Process.Start-Aufrufe
│   ├── SafeData.vb           Datums-/Zahlen-Parsing (de-DE)
│   ├── CheckKey.vb           Lizenzschlüssel-Prüfsumme (Törn)
│   └── CheckKurs.vb          Lizenzschlüssel-Prüfsumme (Kurs)
├── Resources/      Icons, PowerPacks-DLL
├── My Project/     Anwendungseinstellungen
├── docs/           Dokumentation (DEPLOY.md)
├── tools/          Hilfsskripte (smoke-test.ps1)
└── Verwaltung.vbproj
```

## Bauen

Das Projekt kann mit **Visual Studio 2022** oder **MSBuild** gebaut werden:

```powershell
msbuild Verwaltung.vbproj /p:Configuration=Debug /p:Platform=x86
```

Für Release-Builds wird nach dem Build automatisch `sign-output.ps1` ausgeführt (Code-Signierung), damit Windows Defender / Smart App Control die EXE nicht blockiert.

## Smoke-Test

```powershell
powershell -NoProfile -File tools\smoke-test.ps1 -AppDir "bin\x86\Debug"
```

Prüft die EXE-Architektur (x86), vorhandene Laufzeitdateien und Jet-Verfügbarkeit.

## Laufzeitordner

Beim Betrieb entstehen neben der EXE automatisch:

- **`Logs\`** — Tagesbasierte Logdateien (`verwaltung-YYYYMMDD.log`)
- **`Backups\`** — Automatische MDB-Sicherungen vor Schema-Änderungen (max. 10 je Datenbank)

## Lizenzierung

Die Anwendung verwendet ein schlüsselbasiertes Freischaltsystem. Über die Menüoption *Freischaltung* kann der Lizenzschlüssel eingegeben werden, um den vollen Funktionsumfang (Törnverwaltung + Kursverwaltung) freizuschalten.

## Technische Hinweise

- **Datenbankzugriff:** Alle neuen SQL-Abfragen verwenden OleDb-Parameter (`?`-Platzhalter). Bei Jet-Sperren werden Operationen automatisch bis zu 5× wiederholt.
- **Fehlerbehandlung:** Unbehandelte Ausnahmen werden global abgefangen, geloggt und dem Benutzer angezeigt, ohne die Anwendung sofort zu beenden.
- **Backups:** Vor jeder Schema-Änderung (neue Tabellen/Spalten) wird eine Sicherungskopie der betroffenen MDB angelegt.
- **Option Strict:** Für alle Helper-Module aktiviert; in den Forms bleibt `Option Strict Off` aus Kompatibilitätsgründen.
