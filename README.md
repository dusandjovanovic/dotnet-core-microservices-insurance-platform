## .NET Core Mikroservisi sa Docker-om

Prototip projekat za demonstraciju mikroservisa. Arhitektura je bazirana na **Domain-driven dizajnu** i predstavlja uprošćeni sistem za agente osiguranja.

Kornisk (agent) se prijavljuje na sistem i ponudjeno mu je sledeće:
* Prikazivanje proizvoda koje agenti mogu da prodaju
* Nalaženje proizvoda koji odgovaraju njihovim klijentima
* Pravljennje ponuda za koje sistem računa cenu
* Potvrdjivanje ponude, konvertovanje iste u polisu
* Štampanje potvrde polise u vidu sertifikata

## Pokretanje sa Dockerom

Skripte su podeljene u dva dela. Važno je pre svega uspostaviti i podići neophodnu infrastrukturu (PostgreSQL/Message broker) a zatim pokrenuti servise.

* [`infra.yml`](scripts/infra.yml) za podizanje neophodne infrastrukture.
* [`app.yml`](scripts/app.yml) za podizanje kontejnera svih mikroservisa.

Postoje i posebne skripte za build-ovanje i zaustavljanje kontejnera.

Za pokretanje svih mikroservisa nad infrastrkturom (Linux i macOS) bash/zsh:

```bash
./infra-run.sh
./app-run.sh
```
