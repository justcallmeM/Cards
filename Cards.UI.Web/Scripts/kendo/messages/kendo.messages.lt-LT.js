
! function(e) {
    "function" == typeof define && define.amd ? define(["kendo.core.min"], e) : e()
}(function() {
    ! function(e, t) {
        kendo.ui.FlatColorPicker && (kendo.ui.FlatColorPicker.prototype.options.messages = e.extend(!0, kendo.ui.FlatColorPicker.prototype.options.messages, {
            apply: "Patvirtinti",
            cancel: "Atšaukti",
            noColor: "jokios spalvos",
            clearColor: "Skaidri spalva"
        })), kendo.ui.ColorPicker && (kendo.ui.ColorPicker.prototype.options.messages = e.extend(!0, kendo.ui.ColorPicker.prototype.options.messages, {
            apply: "Patvirtinti",
            cancel: "Atšaukti",
            noColor: "jokios spalvos",
            clearColor: "Skaidri spalva"
        })), kendo.ui.ColumnMenu && (kendo.ui.ColumnMenu.prototype.options.messages = e.extend(!0, kendo.ui.ColumnMenu.prototype.options.messages, {
            sortAscending: "Išrikiuoti didėjančiai",
            sortDescending: "Išrikiuoti mažėjančiai",
            filter: "Filtruoti",
            columns: "Stulpeliai",
            done: "Pavirtinti",
            settings: "Stulpelių nustatymai",
            lock: "Užrakinti",
            unlock: "Atrakinti"
        })), kendo.ui.Editor && (kendo.ui.Editor.prototype.options.messages = e.extend(!0, kendo.ui.Editor.prototype.options.messages, {
            bold: "Paryškintas",
            italic: "Kursyvas",
            underline: "Pabrauktas",
            strikethrough: "Perbrauktas",
            superscript: "Viršutinis indeksas",
            subscript: "Apatinis indeksas",
            justifyCenter: "Centruoti",
            justifyLeft: "Lygiuoti pagal kairę",
            justifyRight: "Lygiuoti pagal dešinę",
            justifyFull: "Lygiuoti pagal abi puses",
            insertUnorderedList: "Įterpti nesurikiuotą sąrašą",
            insertOrderedList: "Įterpti surikiuotą sąrašą",
            indent: "Atitraukimas",
            outdent: "Atvirkštinė įtrauka",
            createLink: "Įterpti hipersaitą",
            unlink: "Pašalinti hipersaitą",
            insertImage: "Įterpti paveikslėlį",
            insertFile: "Įterpti failą",
            insertHtml: "Įterpti HTML",
            viewHtml: "Peržiūrėti HTML",
            fontName: "Parinkite šriftą",
            fontNameInherit: "(paveldėtas šriftas",
            fontSize: "Parinkite šriftro dydį",
            fontSizeInherit: "(paveldėtas šrifto dydis)",
            formatBlock: "Formatavimas",
            formatting: "Formatuoti",
            foreColor: "Spalva",
            backColor: "Fono spalva",
            style: "Stiliai",
            emptyFolder: "Tuščias aplankas",
            uploadFile: "Nusiųsti",
            overflowAnchor: "Daugiau įrankių",
            orderBy: "Išrikiuoti pagal:",
            orderBySize: "Dydis",
            orderByName: "Pavadinimas",
            invalidFileType: 'Parinktas failas "{0}" netinkamas - leistini failų tipai yra {1}.',
            deleteFile: 'Ar tikrai norite pašalinti "{0}"?',
            overwriteFile: 'Failas "{0}" jau egzistuoja šiame aplanke. Ar norite jį pakeisti?',
            directoryNotFound: "Aplankas su šiuo pavadinimu nerastas.",
            imageWebAddress: "Žiniatinklio adresas",
            imageAltText: "Alternatyvus tekstas",
            imageWidth: "Plotis (px)",
            imageHeight: "Aukštis (px)",
            fileWebAddress: "Žiniatinklio adresas",
            fileTitle: "Pavadinimas",
            linkWebAddress: "Žiniatinklio adresas",
            linkText: "Tekstas",
            linkToolTip: "Paaiškinimas",
            linkOpenInNewWindow: "Atidaryti nuorodą naujame lange",
            dialogUpdate: "Atnaujinti",
            dialogInsert: "Įterpti",
            dialogButtonSeparator: "arba",
            dialogCancel: "Atšaukti",
            cleanFormatting: "Išvalyti formatavimą",
            createTable: "Įterpti lentelę",
            addColumnLeft: "Pridėti stulpelį kairėje",
            addColumnRight: "Pridėti stulpelį dešinėje",
            addRowAbove: "Pridėti eilutę virš šios",
            addRowBelow: "Pridėti eilutę po šios",
            deleteRow: "Pašalinti eilutę",
            deleteColumn: "Pašalinti stulpelį",
            dialogOk: "Gerai",
            tableWizard: "Lentelės  Žinynas",
            tableTab: "Lentelė",
            cellTab: "Langelis",
            accessibilityTab: "Pasiekiamumas",
            caption: "Antraštė",
            summary: "Santrauka",
            width: "Plotis",
            height: "Aukštis",
            units: "Vienetai",
            cellSpacing: "Langelio Išretinimas",
            cellPadding: "Langelio Tarpai",
            cellMargin: "Langelio Paraštė",
            alignment: "Išdėstymas",
            background: "Fonas",
            cssClass: "CSS Klasė",
            id: "ID",
            border: "Kraštinė",
            borderStyle: "Kraštinės Stilius",
            collapseBorders: "Suskleisti kraštines",
            wrapText: "Apgaubti tekstą",
            associateCellsWithHeaders: "Prijungti langelius prie antraščių",
            alignLeft: "Lygiuoti pagal kairę",
            alignCenter: "Centruoti",
            alignRight: "Lygiuoti pagal dešinę",
            alignLeftTop: "Lygiuoti pagal kairės viršų",
            alignCenterTop: "Centruoti viršuje",
            alignRightTop: "Lygiuoti pagal dešinės viršų",
            alignLeftMiddle: "Lygiuoti pagal kairės vidurį",
            alignCenterMiddle: "Centruoti viduryje",
            alignRightMiddle: "Lygiuoti pagal dešinės vidurį",
            alignLeftBottom: "Lygiuoti pagal kairės apačią",
            alignCenterBottom: "Centruoti apačioje",
            alignRightBottom: "Lygiuoti pagal dešinės apačią",
            alignRemove: "Panaikinti lygiavimą",
            columns: "Stulpeliai",
            rows: "Eilutės",
            selectAllCells: "Pažymėti visus langelius"
        })), kendo.ui.FileBrowser && (kendo.ui.FileBrowser.prototype.options.messages = e.extend(!0, kendo.ui.FileBrowser.prototype.options.messages, {
            uploadFile: "Nusiųsti",
            orderBy: "Išrikiuoti pagal",
            orderByName: "Pavadinimas",
            orderBySize: "Dydis",
            directoryNotFound: "Aplankas su šiuo pavadinimu nerastas.",
            emptyFolder: "Tuščias aplankas",
            deleteFile: 'Ar tikrai norite pašalinti "{0}"?',
            invalidFileType: 'Parinktas failas "{0}" netinkamas - leistini failų tipai yra {1}.',
            overwriteFile: 'Failas "{0}" jau egzistuoja šiame aplanke. Ar norite jį pakeisti?',
            dropFilesHere: "nutempkite failus, kuriuos norite nusiųsti, čia",
            search: "Ieškoti"
        })), kendo.ui.FilterCell && (kendo.ui.FilterCell.prototype.options.messages = e.extend(!0, kendo.ui.FilterCell.prototype.options.messages, {
            isTrue: "taip",
            isFalse: "ne",
            filter: "Filtruoti",
            clear: "Išvalyti",
            operator: "Operatorius"
        })), kendo.ui.FilterCell && (kendo.ui.FilterCell.prototype.options.operators = e.extend(!0, kendo.ui.FilterCell.prototype.options.operators, {
            string: {
                eq: "Lygus",
                neq: "Nelygus",
                startswith: "Prasideda",
                contains: "Turi fragmentą",
                doesnotcontain: "Neturi fragmento",
                endswith: "Baigiasi",
                isnull: "Null",
                isnotnull: "Ne null",
                isempty: "Tuščia",
                isnotempty: "Netuščia"
            },
            number: {
                eq: "Lygus",
                neq: "Nelygus",
                gte: "Didesnis arba lygus",
                gt: "Didesnis",
                lte: "Iki imtinai",
                lt: "Mažesnis",
                isnull: "Null",
                isnotnull: "Ne null"
            },
            date: {
                eq: "Lygi",
                neq: "Nelygi",
                gte: "Didesnė arba lygi",
                gt: "Didesnė",
                lte: "Iki imtinai",
                lt: "Mažesnė",
                isnull: "Null",
                isnotnull: "Ne null"
            },
            enums: {
                eq: "Lygus",
                neq: "Nelygus",
                isnull: "Null",
                isnotnull: "Ne null"
            }
        })), kendo.ui.FilterMenu && (kendo.ui.FilterMenu.prototype.options.messages = e.extend(!0, kendo.ui.FilterMenu.prototype.options.messages, {
            info: "Rodyti, kur reikšmė yra:",
            isTrue: "taip",
            isFalse: "ne",
            filter: "Filtruoti",
            clear: "Išvalyti",
            and: "Ir",
            or: "Arba",
            selectValue: "-Parinkite reikšmę-",
            operator: "Operatorius",
            value: "Vertė",
            cancel: "Atšaukti"
        })), kendo.ui.FilterMenu && (kendo.ui.FilterMenu.prototype.options.operators = e.extend(!0, kendo.ui.FilterMenu.prototype.options.operators, {
            string: {
                eq: "Lygus",
                neq: "Nelygus",
                startswith: "Prasideda",
                contains: "Turi fragmentą",
                doesnotcontain: "Neturi fragmento",
                endswith: "Baigiasi",
                isnull: "Null",
                isnotnull: "Ne null",
                isempty: "Tuščia",
                isnotempty: "Netuščia"
            },
            number: {
                eq: "Lygus",
                neq: "Nelygus",
                gte: "Didesnis arba lygus",
                gt: "Didesnis",
                lte: "Iki imtinai",
                lt: "Mažesnis",
                isnull: "Null",
                isnotnull: "Ne null"
            },
            date: {
                eq: "Lygi",
                neq: "Nelygi",
                gte: "Didesnė arba lygi",
                gt: "Didesnė",
                lte: "Iki imtinai",
                lt: "Mažesnė",
                isnull: "Null",
                isnotnull: "Ne null"
            },
            enums: {
                eq: "Lygus",
                neq: "Nelygus",
                isnull: "Null",
                isnotnull: "Ne null"
            }
        })), kendo.ui.FilterMultiCheck && (kendo.ui.FilterMultiCheck.prototype.options.messages = e.extend(!0, kendo.ui.FilterMultiCheck.prototype.options.messages, {
            checkAll: "Viską parinkti",
            clear: "Išvalyti",
            filter: "Filtruoti",
            search: "Ieškoti"
        })), kendo.ui.Gantt && (kendo.ui.Gantt.prototype.options.messages = e.extend(!0, kendo.ui.Gantt.prototype.options.messages, {
            actions: {
                addChild: "Pridėti Vaiką",
                append: "Pridėti Užduotį",
                insertAfter: "Pridėti Po",
                insertBefore: "Pridėti Virš",
                pdf: "Eksportuoti į PDF"
            },
            cancel: "Atšaukti",
            deleteDependencyWindowTitle: "Delete dependency",
            deleteTaskWindowTitle: "Panaikinti priklausomybę",
            destroy: "Panaikinti",
            editor: {
                assingButton: "Priskirti",
                editorTitle: "Užduotis",
                end: "Baigti",
                percentComplete: "Užbaigti",
                resources: "Resursai",
                resourcesEditorTitle: "Resursai",
                resourcesHeader: "Resursai",
                start: "Pradėti",
                title: "Antraštė",
                unitsHeader: "Vienetai"
            },
            save: "Išsaugoti",
            views: {
                day: "Diena",
                end: "Pabaiga",
                month: "Mėnesis",
                start: "Pradžia",
                week: "Savaitė",
                year: "Metai"
            }
        })), kendo.ui.Grid && (kendo.ui.Grid.prototype.options.messages = e.extend(!0, kendo.ui.Grid.prototype.options.messages, {
            commands: {
                cancel: "Atšaukti pakeitimus",
                canceledit: "Atšaukti",
                create: "Pridėti naują įrašą",
                destroy: "Panaikinti",
                edit: "Redaguoti",
                excel: "Eksportuoti į Excel",
                pdf: "Eksportuoti į PDF",
                save: "Išsaugoti pakeitimus",
                select: "Pažymėti",
                update: "Atnaujinti"
            },
            editable: {
                cancelDelete: "Atšaukti",
                confirmation: "Ar tikrai norite panaikinti šį įvykį?",
                confirmDelete: "Panaikinti"
            },
            noRecords: "Nėra duomenų."
        })), kendo.ui.Groupable && (kendo.ui.Groupable.prototype.options.messages = e.extend(!0, kendo.ui.Groupable.prototype.options.messages, {
            empty: "Nutempkite čia stulpelių, pagal kuriuos norite grupuoti, antraštes"
        })), kendo.ui.NumericTextBox && (kendo.ui.NumericTextBox.prototype.options = e.extend(!0, kendo.ui.NumericTextBox.prototype.options, {
            upArrowText: "Padidinti reikšmes",
            downArrowText: "Pamažinti reikšmes"
        })), kendo.ui.MediaPlayer && (kendo.ui.MediaPlayer.prototype.options.messages = e.extend(!0, kendo.ui.MediaPlayer.prototype.options.messages, {
            pause: "Sustabdyti",
            play: "Paleisti",
            mute: "Užtildyti",
            unmute: "Attildyti",
            quality: "Kokybė",
            fullscreen: "Pilnas Ekranas"
        })), kendo.ui.Pager && (kendo.ui.Pager.prototype.options.messages = e.extend(!0, kendo.ui.Pager.prototype.options.messages, {
            allPages: "Visi",
            display: "{0} - {1} iš {2}",
            empty: "Tuščia",
            page: "Puslapis",
            of: "iš {0}",
            itemsPerPage: "įrašų puslapyje",
            first: "Į pirmą puslapį",
            previous: "Į ankstesnį puslapį",
            next: "Į sekantį puslapį",
            last: "Į paskutinį puslapį",
            refresh: "Atnaujinti",
            morePages: "Daugiau puslapių"
        })), kendo.ui.PivotGrid && (kendo.ui.PivotGrid.prototype.options.messages = e.extend(!0, kendo.ui.PivotGrid.prototype.options.messages, {
            measureFields: "Nutempti duomenų laukus čia",
            columnFields: "Nutempti stulpelių laukus čia",
            rowFields: "Nutempti eilučių laukus čia"
        })), kendo.ui.PivotFieldMenu && (kendo.ui.PivotFieldMenu.prototype.options.messages = e.extend(!0, kendo.ui.PivotFieldMenu.prototype.options.messages, {
            info: "Rodyti įrašus kur:",
            filterFields: "Paieškos laukai",
            filter: "Filtras",
            include: "Pridėti laukus",
            title: "Įtraukti laukus",
            clear: "Išvalyti",
            ok: "Gerai",
            cancel: "Atšaukti",
            operators: {
                contains: "Turi fragmentą",
                doesnotcontain: "neturi fragmento",
                startswith: "Prasideda",
                endswith: "Baigiasi",
                eq: "Lygus",
                neq: "Nelygus"
            }
        })), kendo.ui.RecurrenceEditor && (kendo.ui.RecurrenceEditor.prototype.options.messages = e.extend(!0, kendo.ui.RecurrenceEditor.prototype.options.messages, {
            frequencies: {
                never: "Niekada",
                hourly: "Kas valandą",
                daily: "Kas dieną",
                weekly: "Kas savaitę",
                monthly: "Kas mėnesį",
                yearly: "Kas metus"
            },
            hourly: {
                repeatEvery: "Kartoti kiekvieną: ",
                interval: " valandą(-as)"
            },
            daily: {
                repeatEvery: "Kartoti kiekvieną: ",
                interval: " dieną(-as)"
            },
            weekly: {
                interval: " savaitę(-es)",
                repeatEvery: "Kartoti kiekvieną: ",
                repeatOn: "Kartoti: "
            },
            monthly: {
                repeatEvery: "Kartoti kiekvieną: ",
                repeatOn: "Kartoti: ",
                interval: " mėnesį(-ius)",
                day: "Dieną "
            },
            yearly: {
                repeatEvery: "Kartoti kiekvieną: ",
                repeatOn: "Kartoti: ",
                interval: " metus",
                of: " iš "
            },
            end: {
                label: "Pabaiga:",
                mobileLabel: "Baigiasi",
                never: "Niekada",
                after: "Po ",
                occurrence: " pasikartojimų",
                on: "Ant "
            },
            offsetPositions: {
                first: "Pirmas",
                second: "Antras",
                third: "Trečias",
                fourth: "Ketvirtas",
                last: "Paskutinis"
            },
            weekdays: {
                day: "diena",
                weekday: "savaitės diena",
                weekend: "savaitgalio diena"
            }
        })), kendo.ui.Scheduler && (kendo.ui.Scheduler.prototype.options.messages = e.extend(!0, kendo.ui.Scheduler.prototype.options.messages, {
            allDay: "visą dieną",
            date: "Data",
            event: "Įvykis",
            time: "Laikas",
            showFullDay: "Visa diena",
            showWorkDay: "Darbo valandos ",
            today: "Šiandien",
            save: "Išsaugoti",
            cancel: "Atšaukti",
            destroy: "Panaikinti",
            deleteWindowTitle: "Panaikinti įvykį",
            ariaSlotLabel: "Pasirinkta nuo {0:t}ikito {1:t}",
            ariaEventLabel: "{0} {1:D} {2:t}",
            editable: {
                confirmation: "Ar tikrai norite panaikinti šį įvykį?"
            },
            views: {
                day: "Diena",
                week: "Savaitė",
                workWeek: "Darbo savaitė",
                agenda: "Darbotvarkė",
                month: "Mėnesis",
                timeline: "Laiko juosta"
            },
            recurrenceMessages: {
                deleteWindowTitle: "Pašalinti įvykį",
                deleteWindowOccurrence: "Panaikinti tik šį elementą",
                deleteWindowSeries: "Panaikinti visus pasikartojimus",
                editWindowTitle: "Redaguoti pasikartojimą",
                editWindowOccurrence: "Redaguoti šį elementą",
                editWindowSeries: "Redaguoti visus pasikartojimus",
                deleteRecurring: "Norite panaikinti tik šį elementą ar visus pasikartojimus?",
                editRecurring: "Norite redaguoti tik šį elementą ar visus pasikartojimus?"
            },
            editor: {
                title: "Įvykis",
                start: "Pradžia",
                end: "Pabaiga",
                allDayEvent: "Visos dienos įvykis",
                description: "Aprašymas",
                repeat: "Kartoti",
                timezone: " ",
                startTimezone: "Laiko zona",
                endTimezone: "Laiko zona",
                separateTimezones: "Naudoti skirtingas laiko zonas",
                timezoneEditorTitle: "Laiko zonos",
                timezoneEditorButton: "laiko zonos",
                timezoneTitle: "Laiko zonos",
                noTimezone: "Jokių laiko zonų",
                editorTitle: "Įvykis"
            }
        })), kendo.spreadsheet && kendo.spreadsheet.messages.borderPalette && (kendo.spreadsheet.messages.borderPalette = e.extend(!0, kendo.spreadsheet.messages.borderPalette, {
            allBorders: "Visos kraštinės",
            insideBorders: "Vidinės kraštinės",
            insideHorizontalBorders: "Vidinės horizontalios kraštinės",
            insideVerticalBorders: "Vidinės vertikalios kraštinės",
            outsideBorders: "Išorinės kraštinės",
            leftBorder: "Kairinė kraštinė",
            topBorder: "Viršutinė kraštinė",
            rightBorder: "Dešinė kraštinė",
            bottomBorder: "Apatinė kraštinė",
            noBorders: "Jokios kraštinės",
            reset: "Atstatyti spalvą",
            customColor: "Norima spalva...",
            apply: "Patvirtinti",
            cancel: "Atšaukti"
        })), kendo.spreadsheet && kendo.spreadsheet.messages.dialogs && (kendo.spreadsheet.messages.dialogs = e.extend(!0, kendo.spreadsheet.messages.dialogs, {
            apply: "Patvirtinti",
            save: "Išsaugoti",
            cancel: "Atšaukti",
            remove: "Pašalinti",
            retry: "Pakartoti",
            revert: "Atstatyti",
            okText: "Gerai",
            formatCellsDialog: {
                title: "Formatuoti",
                categories: {
                    number: "Skaičiai",
                    currency: "Valiuta",
                    date: "Data"
                }
            },
            fontFamilyDialog: {
                title: "Šriftas"
            },
            fontSizeDialog: {
                title: "Šrifto dydis"
            },
            bordersDialog: {
                title: "Kraštinės"
            },
            alignmentDialog: {
                title: "Išdėstymas",
                buttons: {
                    justtifyLeft: "Lygiuoti pagal kairę",
                    justifyCenter: "Centruoti",
                    justifyRight: "Lygiuoti pagal dešinę",
                    justifyFull: "Lygiuoti pagal abi puses",
                    alignTop: "Lygiuoti viršuje",
                    alignMiddle: "Lygiuoti viduryje",
                    alignBottom: "Lygiuoti apačioje"
                }
            },
            mergeDialog: {
                title: "Sulieti langelius",
                buttons: {
                    mergeCells: "Sulieti visus",
                    mergeHorizontally: "Sulieti horizontaliai",
                    mergeVertically: "Sulieti vertikaliai",
                    unmerge: "Atskirti"
                }
            },
            freezeDialog: {
                title: "Užšaldyti langus",
                buttons: {
                    freezePanes: "Užšaldyti langus",
                    freezeRows: "Užšaldyti eilutes",
                    freezeColumns: "Užšaldyti stulpeliu",
                    unfreeze: "Atšaldyti langus"
                }
            },
            validationDialog: {
                title: "Datos Patvirtinimas",
                hintMessage: "Prašau įvesti tinkamą {0} reikšmę {1}.",
                hintTitle: "Pavirtinimas {0}",
                criteria: {
                    any: "Bet kokia reikšmė",
                    number: "Skaičius",
                    text: "Tekstas",
                    date: "Data",
                    custom: "Norima formulė",
                    list: "Sąrašas"
                },
                comparers: {
                    greaterThan: "nuo",
                    lessThan: "iki",
                    between: "tarp",
                    notBetween: "ne tarp",
                    equalTo: "lygu",
                    notEqualTo: "nelygu",
                    greaterThanOrEqualTo: "nuo imtinai",
                    lessThanOrEqualTo: "iki imtinai"
                },
                comparerMessages: {
                    greaterThan: "daugiau nei {0}",
                    lessThan: "mažiau nei {0}",
                    between: "tarp {0} ir {1}",
                    notBetween: "ne tarp {0} ir {1}",
                    equalTo: "lygu {0}",
                    notEqualTo: "nelygu {0}",
                    greaterThanOrEqualTo: "daugiau arba lygu {0}",
                    lessThanOrEqualTo: "mažiau arba lygu {0}",
                    custom: "kuris patenkita formulę: {0}"
                },
                labels: {
                    criteria: "Kriterijus",
                    comparer: "Palyginimas",
                    min: "Mažiausiai",
                    max: "Daugiausiai",
                    value: "Vertė",
                    start: "Pradžia",
                    end: "Pabaga",
                    onInvalidData: "Ant netinkamos informacijos",
                    rejectInput: "Atmesti įvestį",
                    showWarning: "Rodyti įspėjimą",
                    showHint: "Rodyti užuominą",
                    hintTitle: "Užuominos antraštė",
                    hintMessage: "Užuominos žinutė",
                    ignoreBlank: "Ignoruoti tuščią"
                },
                placeholders: {
                    typeTitle: "Tipo antraštė",
                    typeMessage: "Tipo žinutė"
                }
            },
            saveAsDialog: {
                title: "Išsaugoti kaip...",
                labels: {
                    fileName: "Failo pavadinimas",
                    saveAsType: "Išsaugoti kaip"
                }
            },
            exportAsDialog: {
                title: "Eksportuoti...",
                labels: {
                    fileName: "Failo pavadinimas",
                    saveAsType: "Išsaugoti kaip tipas",
                    exportArea: "Eksportuoti",
                    paperSize: "Popieriaus dydis",
                    margins: "Paraštės",
                    orientation: "Orientacija",
                    print: "Spausdinti",
                    guidelines: "Gairės",
                    center: "Centras",
                    horizontally: "Horizontaliai",
                    vertically: "Vertikaliai"
                }
            },
            modifyMergedDialog: {
                errorMessage: "Neglaima pakeisti dalies sulieto langelio."
            },
            useKeyboardDialog: {
                title: "Kopijuojama ir įklijuojama",
                errorMessage: "Šie vieksmai negali būti atlikti meniu. Prašome naudoti klaviatūros sparčiuosius klavišus:",
                labels: {
                    forCopy: "kopijai",
                    forCut: "iškirpimui",
                    forPaste: "įklijavimui"
                }
            },
            unsupportedSelectionDialog: {
                errorMessage: "Šis veiksmas negalimas atlikti ant keletos pasirinkimų."
            }
        })), kendo.spreadsheet && kendo.spreadsheet.messages.filterMenu && (kendo.spreadsheet.messages.filterMenu = e.extend(!0, kendo.spreadsheet.messages.filterMenu, {
            sortAscending: "Išrikiuoti nuo A iki Z",
            sortDescending: "Išrikiuoti nuo Z iki A",
            filterByValue: "Ieškoti pagal reikšmę",
            filterByCondition: "Ieškoti pagal būseną",
            apply: "Patvirtinti",
            search: "Ieškoti",
            addToCurrent: "Pridėti prie pasirinkto",
            clear: "Išvalyti",
            blanks: "(Tušti)",
            operatorNone: "Jokie",
            and: "IR",
            or: "ARBA",
            operators: {
                string: {
                    contains: "Tekste yra",
                    doesnotcontain: "Tekste nėra",
                    startswith: "Tekstas prasideda",
                    endswith: "Tekstas baigiasi"
                },
                date: {
                    eq: "Data yra",
                    neq: "Data nėra",
                    lt: "Dat yra prieš",
                    gt: "Data yra pro"
                },
                number: {
					eq: "Lygi",
					neq: "Nelygi",
					gte: "Didesnė arba lygi",
					gt: "Didesnė",
					lte: "Iki imtinai",
					lt: "Mažesnė",
                }
            }
        })), kendo.spreadsheet && kendo.spreadsheet.messages.toolbar && (kendo.spreadsheet.messages.toolbar = e.extend(!0, kendo.spreadsheet.messages.toolbar, {
            addColumnLeft: "Pridėti stulpelį kairėje",
            addColumnRight: "Pridėti stulpelį dešinėje",
            addRowAbove: "Pridėti eilutę virš šios",
            addRowBelow: "Pridėti eilutę po šios",
            alignment: "Lygiavimas",
            alignmentButtons: {
                justtifyLeft: "Lygiuoti pagal kairę",
                justifyCenter: "Centruoti",
                justifyRight: "Lygiuoti pagal dešinę",
                justifyFull: "Lygiuoti pagal abi puses",
                alignTop: "Lygiuoti viršuje",
                alignMiddle: "Lygiuoti viduryje",
                alignBottom: "Lygiuoti apačioje"
            },
            backgroundColor: "Fonas",
            bold: "Paryškinti",
            borders: "Kraštinės",
            colorPicker: {
                reset: "Atstayti spalvą",
                customColor: "Norima spalva..."
            },
            copy: "Kopijuoti",
            cut: "Iškirpti",
            deleteColumn: "Panaikinti stulpelį",
            deleteRow: "Panaikinti eilutę",
            excelImport: "Importuoti iš Excel...",
            filter: "Filtras",
            fontFamily: "Šriftas",
            fontSize: "Šrifto dydis",
            format: "Norimas formatavimas...",
            formatTypes: {
                automatic: "Automatinis",
                number: "Skaičiai",
                percent: "Procentai",
                financial: "Finansinis",
                currency: "Valiuta",
                date: "Data",
                time: "Laikas",
                dateTime: "Data laikas",
                duration: "Trukmė",
                moreFormats: "Daugiau formatavimų..."
            },
            formatDecreaseDecimal: "Padidinti dešimtainį skaičių",
            formatIncreaseDecimal: "Pamažinti dešimtainį skaičių",
            freeze: "Užšaldyti langus",
            freezeButtons: {
                freezePanes: "Užšaldyti langus",
                freezeRows: "Užšaldyti eilutes",
                freezeColumns: "Užšaldyti stulpeliu",
                unfreeze: "Atšaldyti langus"
            },
            italic: "Kursyvas",
            merge: "Sulieti langelius",
            mergeButtons: {
                mergeCells: "Sulieti visus",
                mergeHorizontally: "Sulieti horizontaliai",
                mergeVertically: "Sulieti vertikaliai",
                unmerge: "Atskirti"
            },
            open: "Atidaryti...",
            paste: "Įklijuoti",
            quickAccess: {
                redo: "Perdaryti",
                undo: "Anuliuoti"
            },
            saveAs: "Išsaugoti kaip...",
            sort: "Išrikiuoti",
            sortAsc: "Išrikiuoti didėjančiai",
            sortDesc: "Išrikiuoti mažėjančiai",
            sortButtons: {
                sortSheetAsc: "Išrikiuoti lakštą nuo A iki Z",
                sortSheetDesc: "Išrikiuoti lakštą nuo Z iki A",
                sortRangeAsc: "Rikiavimo intervalas nuo A iki Z",
                sortRangeDesc: "Rikiavimo intervalas nuo Z iki A"
            },
            textColor: "Teksto spalva",
            textWrap: "Apgaubti tekstą",
            underline: "Pabraukti",
            validation: "Informacijos patvirtinimas..."
        })), kendo.spreadsheet && kendo.spreadsheet.messages.view && (kendo.spreadsheet.messages.view = e.extend(!0, kendo.spreadsheet.messages.view, {
            nameBox: "Pavadinimo laukas",
            errors: {
                shiftingNonblankCells: "Negalima įterpti laukelių, nes galimas duomenų praradimas. Pasirinkite kitą vietą arba ištrinkite informaciją iš darbalapio galo.",
                filterRangeContainingMerges: "Negalima sukurti filtro šiuo intervalu",
                validationError: "Reikšme pažeidžia langelip patvirtinimo taisykles."
            },
            tabs: {
                home: "Namai",
                insert: "Iterpti",
                data: "Informacija"
            }
        })), kendo.ui.Slider && (kendo.ui.Slider.prototype.options = e.extend(!0, kendo.ui.Slider.prototype.options, {
            increaseButtonTitle: "Padidinti",
            decreaseButtonTitle: "Pamažinti"
        })), kendo.ui.TreeList && (kendo.ui.TreeList.prototype.options.messages = e.extend(!0, kendo.ui.TreeList.prototype.options.messages, {
            noRows: "Nėra jokių įrašų",
            loading: "Kraunama...",
            requestFailed: "Užklausa nepavyko.",
            retry: "Bandyti vėl",
            commands: {
                edit: "Redaguoti",
                update: "Atnaujinti",
                canceledit: "Atšaukti",
                create: "Pridėti naują įrašą",
                createchild: "Pridėti naują vaikinį įrašą",
                destroy: "Panaikinti",
                excel: "Eksportuoti į Excel",
                pdf: "Eksportuoti į PDF"
            }
        })), kendo.ui.TreeList && (kendo.ui.TreeList.prototype.options.columnMenu = e.extend(!0, kendo.ui.TreeList.prototype.options.columnMenu, {
            messages: {
                columns: "Pasirinkti stulpelius",
                filter: "Pritaikyti filtrus",
                sortAscending: "Rūšiuoti (did)",
                sortDescending: "Rūšiuoti (maž)"
            }
        })), kendo.ui.TreeView && (kendo.ui.TreeView.prototype.options.messages = e.extend(!0, kendo.ui.TreeView.prototype.options.messages, {
            loading: "Kraunama...",
            requestFailed: "Užklausa nepavyko.",
            retry: "Bandyti vėl."
        })), kendo.ui.Upload && (kendo.ui.Upload.prototype.options.localization = e.extend(!0, kendo.ui.Upload.prototype.options.localization, {
            select: "Pasirinkti failą",
            cancel: "Atšaukti",
            retry: "Bandyti vėl",
            remove: "Panaikinti",
            uploadSelectedFiles: "Įkelti failus",
            dropFilesHere: "nutempkite failus, kuriuos norite nusiųsti, čia",
            statusUploading: "įkeliama",
            statusUploaded: "įkelta",
            statusWarning: "įspėjimas",
            statusFailed: "nepavyko",
            headerStatusUploading: "Įkeliama...",
            headerStatusUploaded: "Įkelta",
            invalidFileExtension:"Neteisingas failo tipas"
        })), kendo.ui.Validator && (kendo.ui.Validator.prototype.options.messages = e.extend(!0, kendo.ui.Validator.prototype.options.messages, {
            required: "{0} yra privaloma",
            pattern: "{0} yra neleidžiama",
            min: "{0} turi būti didesnis arba lygus {1}",
            max: "{0} turi būti mažesnis arba lygus {1}",
            step: "{0} yra neleidžiama",
            email: "{0} yra netinkamas el. paštas",
            url: "{0} yra netinkama nuoroda",
            date: "{0} yra netinkama data",
            dateCompare: "Pabaigos data turi būti vėlesnė už pradžios datą"
        })), kendo.ui.Dialog && (kendo.ui.Dialog.prototype.options.messages = e.extend(!0, kendo.ui.Dialog.prototype.options.localization, {
            close: "Uždaryti"
        })), kendo.ui.Alert && (kendo.ui.Alert.prototype.options.messages = e.extend(!0, kendo.ui.Alert.prototype.options.localization, {
            okText: "Gerai"
        })), kendo.ui.Confirm && (kendo.ui.Confirm.prototype.options.messages = e.extend(!0, kendo.ui.Confirm.prototype.options.localization, {
            okText: "Gerai",
            cancel: "Atšaukti"
        })), kendo.ui.Prompt && (kendo.ui.Prompt.prototype.options.messages = e.extend(!0, kendo.ui.Prompt.prototype.options.localization, {
            okText: "Gerai",
            cancel: "Atšaukti"
        }))
    }(window.kendo.jQuery)
});
//# sourceMappingURL=kendo.messages.en-GB.min.js.map