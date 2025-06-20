# Dataspot Autorun

🛰️ Aplikacija koja se automatski pokreće prilikom svakog paljenja Windows računala i otvara zadani URL u Microsoft Edge pregledniku.

---

## 🇭🇷 Upute (Croatian)

### 🔧 Što radi

- Kopira se u `Appdata\Roaming\dataspot_autorun`
- Dodaje se u Registry:  
  `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run`
- Otvara URL: [https://submarine.dataspot.ltd](https://submarine.dataspot.ltd)
- Ne zahtijeva administratorska prava
- Radi neprimjetno u pozadini

### 🖥️ Instalacija

1. Preuzmi `.exe` iz [![Download Release](https://img.shields.io/github/v/release/flaskarin/dataspot?label=Download%20Release&style=for-the-badge)](https://github.com/flaskarin/dataspot/releases).
2. Pokreni `.exe` (admin pristup nije potreban).
3. Aplikacija se automatski kopira u `Appdata\Roaming\dataspot_autorun` i nakon prvog pokretanja se može izbrisati originalna kopija, ali NE KOPIRANA.
4. Svakim novim paljenjem računala, otvara zadani URL u Edgeu.

### 🧪 Testirano na

- ✅ Windows 10
- ✅ Windows 11
- ✅ Microsoft Edge (zadani preglednik)

### 🧼 Uklanjanje

- Obriši folder `Appdata\Roaming\dataspot_autorun`
- Ili ukloni unos iz Registry-ja preko `regedit`:
  
  HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run

---

## 🇬🇧 Instructions (English)

### 🔧 What it does

- Copies itself to:  `Appdata\Roaming\dataspot_autorun`
- Adds itself to Registry startup:  
  `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run`
- Automatically opens: [https://submarine.dataspot.ltd](https://submarine.dataspot.ltd)
- No admin rights required
- Runs silently in the background

### 🖥️ Installation

1. Download the `.exe` from the [![Download Release](https://img.shields.io/github/v/release/flaskarin/dataspot?label=Download%20Release&style=for-the-badge)](https://github.com/flaskarin/dataspot/releases) page.
2. Run the `.exe` (no admin prompt).
3. The app copies itself into `Appdata\Roaming\dataspot_autorun`and runs automatically, after the first execution of the app the original `.exe` can be deleted.
4. On every reboot, it will open the target URL in Microsoft Edge.

### 🧪 Tested on

- ✅ Windows 10
- ✅ Windows 11
- ✅ Microsoft Edge (preinstalled)

### 🧼 Removal

- Delete the folder:  `Appdata\Roaming\dataspot_autorun`
- Or remove the registry entry via `regedit`:
  
  HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run

---

© 2025 dataspot
