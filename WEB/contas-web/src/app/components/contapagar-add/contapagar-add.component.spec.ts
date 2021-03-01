import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContapagarAddComponent } from './contapagar-add.component';

describe('ContapagarAddComponent', () => {
  let component: ContapagarAddComponent;
  let fixture: ComponentFixture<ContapagarAddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ContapagarAddComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ContapagarAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
