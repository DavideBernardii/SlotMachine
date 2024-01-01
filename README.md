# SlotMachine

![SlotMachine drawio](https://github.com/DavideBernardii/SlotMachine/assets/127590023/239acf86-2fcf-4e81-afbd-770b4d4f25c1)

## Scopo codice
L'obbiettivo è creare una slot machine in cui ogni moneta inserita permette di giocare una partita in cui girano le tre rotelle della slot machine e appaiono tre simboli.
L’utente per sole due volte può decidere di tenere una o più lettere apparse e far girare nuovamente le rotelle o fermarsi.
Una volta che si ferma:
- se c’è una coppia viene restituita una moneta 
- se c’è un tris di lettere uguali vengono restituite un numero di monete pari alla posizione in ordine alfabetico della lettera del tris.
- se ci sono tre simboli consecutivi vengono restituite 50 monete. 
- se ci sono tre Z allora è JACKPOT e vengono restituite 100 monetine
altrimenti non viene restituito nulla e si passa alla partita successiva inserendo una nuova monetina.
Le monete vinte possono essere rigiocate oppure riscosse dal giocatore. 
