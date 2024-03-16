import { Component, OnInit } from '@angular/core';
import { Comprobantes } from '../Models/Comprobantes';
import { Contribuyentes } from '../Models/Contribuyentes';
import { ContribuyentesService } from '../Services/contribuyentes.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  contribuyentes: Contribuyentes[] = [];
  comprobantes: Comprobantes[] = [];
  totalComprobantesItbis: number;
  constructor(private contribuyentesService: ContribuyentesService) {

  }
  ngOnInit(): void {
    this.contribuyentesService.getContribuyentes().subscribe((data: Contribuyentes[]) => {
      this.contribuyentes = data;
    });
  }
  getComprobantes(rncCedula: number): void {
    //alert(rncCedula);
    this.contribuyentesService.getComprobantes(rncCedula).subscribe((data: Comprobantes[]) => {
      this.comprobantes = data;
      this.totalComprobantesItbis = this.comprobantes.reduce((
        acc,
        obj,
      ) => acc + (obj.itbis18),
        0);
    });
  }
}
