import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContapagarDeleteComponent } from './contapagar-delete.component';

describe('ContapagarDeleteComponent', () => {
  let component: ContapagarDeleteComponent;
  let fixture: ComponentFixture<ContapagarDeleteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ContapagarDeleteComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ContapagarDeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
