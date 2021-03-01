import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

import { ContapagarService } from 'src/app/services/contapagar.service';

@Component({
  selector: 'app-contapagar-add',
  templateUrl: './contapagar-add.component.html',
  styleUrls: ['./contapagar-add.component.css']
})
export class ContapagarAddComponent implements OnInit {
  contaForm = new FormGroup({
    nome: new FormControl('', [Validators.required]),
    valor: new FormControl('', [Validators.required]),
    datavencimento: new FormControl('', [Validators.required]),
    datapagamento: new FormControl('', [Validators.required]),
  });

  submitted: boolean = false;
  withError: boolean = false;

  constructor(private service: ContapagarService) { }

  ngOnInit(): void { }

  withControlError(name: string, error: string = ''): boolean {
    let control = this.contaForm.get(name);

    if (control) {
      if (error) {
        return control.invalid && control.errors && (control.dirty || control.touched) && control.hasError(error);
      }
      else {
        return control.invalid && control.errors && (control.dirty || control.touched);
      }
    }
    else {
      return false;
    }
  }

  add(): void {
    this.submitted = false;
    this.withError = false;

    if (this.contaForm.invalid) {
      return;
    }

    this.service.add(this.contaForm.value)
      .subscribe(
        response => {
          this.submitted = true;
          this.withError = false;
          this.contaForm.reset();
        },
        error => {
          this.submitted = true;
          this.withError = true;

          console.log(error);
        }
      );
  }
}
