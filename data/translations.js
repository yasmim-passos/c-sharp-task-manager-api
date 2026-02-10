const TRANSLATIONS = {
  // PORTUGUÊS
  pt: {

    nav: {
      home: 'Home',
      dashboard: 'Dashboard',
      projects: 'Projetos',
      skills: 'Skills',
      softSkills: 'Soft Skills',
      contact: 'Contato'
    },

    hero: {
      badge: 'Disponível para Oportunidades',
      greeting: 'Olá, sou',
      role: 'Desenvolvedora Full Stack | Especialista em Arquitetura de Software',
      description: 'Transformo código complexo em soluções elegantes. Especializada em refatoração, design patterns e arquiteturas escaláveis.',
      viewProjects: 'Ver Projetos',
      contact: 'Entrar em Contato'
    },

    dashboard: {
      title: 'Portfolio Dashboard',
      subtitle: 'Métricas e estatísticas dos meus principais projetos',
      projects: 'Projetos',
      loc: 'Linhas de Código',
      files: 'Arquivos',
      technologies: 'Tecnologias'
    },

    projects: {
      title: 'Projetos em Destaque',
      subtitle: 'Trabalhos que demonstram expertise em arquitetura e design patterns',
      viewGithub: 'Ver no GitHub'
    },

    // HARD SKILLS
    skills: {
      title: 'Stack Tecnológico',
      subtitle: 'Linguagens, frameworks e ferramentas',

      skills: [
          { icon:'🐍', name:'Python', category:'Language', level:95 },
          { icon:'☕', name:'Java', category:'Language', level:90 },
          { icon:'🔵', name:'.NET', category:'Platform', level:85 },

          { icon:'🧠', name:'C', category:'Language', level:80 },
          { icon:'⚙️', name:'C++', category:'Language', level:80 },
          { icon:'🟨', name:'JavaScript', category:'Language', level:90 },

          { icon:'🌐', name:'HTML', category:'Markup', level:95 },
          { icon:'🎨', name:'CSS', category:'Stylesheet', level:90 },

          { icon:'🗄️', name:'SQL', category:'Database', level:90 },
          { icon:'🐘', name:'PostgreSQL', category:'Database', level:85 },

          { icon:'⚡', name:'FastAPI', category:'Framework', level:90 },
          { icon:'🍃', name:'Spring Boot', category:'Framework', level:95 },

          { icon:'🐳', name:'Docker', category:'DevOps', level:85 },
          { icon:'🔧', name:'Git', category:'Tools', level:90 },
          { icon:'🛠️', name:'GitHub', category:'Tools', level:90 }
      ]
    },

    // SOFT SKILLS
    softSkills: {
      title: 'Soft Skills',
      subtitle: 'Competências comportamentais e interpessoais',

      skills: [
        { icon:'🧠', name:'Raciocínio Lógico', description:'Pensamento analítico e resolução estruturada de problemas' },
        { icon:'🚀', name:'Proatividade', description:'Iniciativa e autonomia para identificar e resolver desafios' },
        { icon:'🤝', name:'Trabalho em Equipe', description:'Comunicação clara e colaboração efetiva' },
        { icon:'📚', name:'Aprendizado Contínuo', description:'Constante atualização em novas tecnologias' },
        { icon:'🎯', name:'Foco em Qualidade', description:'Comprometimento com boas práticas e código limpo' },
        { icon:'⚡', name:'Adaptabilidade', description:'Flexibilidade para novos desafios e tecnologias' },
        { icon:'⏰', name:'Gestão do Tempo', description:'Organização e cumprimento de prazos' },
        { icon:'🌐', name:'Comunicação Técnica', description:'Explicação clara de conceitos técnicos para diferentes públicos e equipes' },
        { icon:'💡', name:'Resolução de Problemas', description:'Análise crítica e soluções criativas' }
      ]
    },

    contact: {
      title: 'Vamos Trabalhar Juntos?',
      subtitle: 'Estou disponível para oportunidades e projetos interessantes',
      email: 'Email',
      github: 'GitHub',
      linkedin: 'LinkedIn'
    }
  },

  // ENGLISH
  en: {
    nav: {
      home: 'Home',
      dashboard: 'Dashboard',
      projects: 'Projects',
      skills: 'Skills',
      softSkills: 'Soft Skills',
      contact: 'Contact'
    },

    hero: {
      badge: 'Available for Opportunities',
      greeting: "Hi, I'm",
      role: 'Full Stack Developer | Software Architecture Specialist',
      description: 'I transform complex code into elegant solutions. Specialized in refactoring, design patterns and scalable architectures',
      viewProjects: 'View Projects',
      contact: 'Get in Touch'
    },

    dashboard: {
      title: 'Portfolio Dashboard',
      subtitle: 'Metrics and statistics of my main projects',
      projects: 'Projects',
      loc: 'Lines of Code',
      files: 'Files',
      technologies: 'Technologies'
    },

    projects: {
      title: 'Featured Projects',
      subtitle: 'Work demonstrating expertise in architecture and design patterns',
      viewGithub: 'View on GitHub'
    },

    skills: {
    title: 'Stack Tecnológico',
    subtitle: 'Linguagens, frameworks e ferramentas',

    skills: [
        { icon:'🐍', name:'Python', category:'Language', level:95 },
        { icon:'☕', name:'Java', category:'Language', level:90 },
        { icon:'🔵', name:'.NET', category:'Platform', level:85 },

        { icon:'🧠', name:'C', category:'Language', level:80 },
        { icon:'⚙️', name:'C++', category:'Language', level:80 },
        { icon:'🟨', name:'JavaScript', category:'Language', level:90 },

        { icon:'🌐', name:'HTML', category:'Markup', level:95 },
        { icon:'🎨', name:'CSS', category:'Stylesheet', level:90 },

        { icon:'🗄️', name:'SQL', category:'Database', level:90 },
        { icon:'🐘', name:'PostgreSQL', category:'Database', level:85 },

        { icon:'⚡', name:'FastAPI', category:'Framework', level:90 },
        { icon:'🍃', name:'Spring Boot', category:'Framework', level:95 },

        { icon:'🐳', name:'Docker', category:'DevOps', level:85 },
        { icon:'🔧', name:'Git', category:'Tools', level:90 },
        { icon:'🛠️', name:'GitHub', category:'Tools', level:90 }
      ]
    },

    softSkills: {
      title: 'Soft Skills',
      subtitle: 'Behavioral and interpersonal competencies',

      skills: [
        { icon:'🧠', name:'Logical Thinking', description:'Analytical thinking and structured problem solving' },
        { icon:'🚀', name:'Proactivity', description:'Initiative and autonomy to identify and solve challenges' },
        { icon:'🤝', name:'Teamwork', description:'Clear communication and effective collaboration' },
        { icon:'📚', name:'Continuous Learning', description:'Constant updating in new technologies' },
        { icon:'🎯', name:'Quality Focus', description:'Commitment to best practices and clean code' },
        { icon:'⚡', name:'Adaptability', description:'Flexibility for new challenges and technologies' },
        { icon:'⏰', name:'Time Management', description:'Organization and meeting deadlines' },
        { icon:'🌐', name:'Technical Communication', description:'Clear explanation of technical concepts for different audiences and teams' },
        { icon:'💡', name:'Problem Solving', description:'Critical analysis and creative solutions' }
      ]
    },

    contact: {
      title: "Let's Work Together?",
      subtitle: "I'm available for opportunities and interesting projects",
      email: 'Email',
      github: 'GitHub',
      linkedin: 'LinkedIn'
    }
  },

  // ESPAÑOL
  es: {
    nav: {
      home: 'Inicio',
      dashboard: 'Dashboard',
      projects: 'Proyectos',
      skills: 'Skills',
      softSkills: 'Soft Skills',
      contact: 'Contacto'
    },

    hero: {
      badge: 'Disponible para Oportunidades',
      greeting: 'Hola, soy',
      role: 'Desarrolladora Full Stack | Especialista en Arquitectura de Software',
      description: 'Transformo código complejo en soluciones elegantes. Especializada en refactorización, patrones de diseño y arquitecturas escalables.',
      viewProjects: 'Ver Proyectos',
      contact: 'Contactar'
    },

    dashboard: {
      title: 'Dashboard del Portfolio',
      subtitle: 'Métricas y estadísticas de mis principales proyectos',
      projects: 'Proyectos',
      loc: 'Líneas de Código',
      files: 'Archivos',
      technologies: 'Tecnologías'
    },

    projects: {
      title: 'Proyectos Destacados',
      subtitle: 'Trabajos que demuestran experiencia en arquitectura y patrones de diseño',
      viewGithub: 'Ver en GitHub'
    },

    skills: {
    title: 'Stack Tecnológico',
    subtitle: 'Lenguajes, frameworks y herramientas',

    skills: [
        { icon:'🐍', name:'Python', category:'Language', level:95 },
        { icon:'☕', name:'Java', category:'Language', level:90 },
        { icon:'🔵', name:'.NET', category:'Platform', level:85 },

        { icon:'🧠', name:'C', category:'Language', level:80 },
        { icon:'⚙️', name:'C++', category:'Language', level:80 },
        { icon:'🟨', name:'JavaScript', category:'Language', level:90 },

        { icon:'🌐', name:'HTML', category:'Markup', level:95 },
        { icon:'🎨', name:'CSS', category:'Stylesheet', level:90 },

        { icon:'🗄️', name:'SQL', category:'Database', level:90 },
        { icon:'🐘', name:'PostgreSQL', category:'Database', level:85 },

        { icon:'⚡', name:'FastAPI', category:'Framework', level:90 },
        { icon:'🍃', name:'Spring Boot', category:'Framework', level:95 },

        { icon:'🐳', name:'Docker', category:'DevOps', level:85 },
        { icon:'🔧', name:'Git', category:'Tools', level:90 },
        { icon:'🛠️', name:'GitHub', category:'Tools', level:90 }
      ]
    },

    softSkills: {
      title: 'Soft Skills',
      subtitle: 'Competencias conductuales e interpersonales',

      skills: [
        { icon:'🧠', name:'Pensamiento Lógico', description:'Pensamiento analítico y resolución estructurada de problemas' },
        { icon:'🚀', name:'Proactividad', description:'Iniciativa y autonomía para identificar y resolver desafíos' },
        { icon:'🤝', name:'Trabajo en Equipo', description:'Comunicación clara y colaboración efectiva' },
        { icon:'📚', name:'Aprendizaje Continuo', description:'Actualización constante en nuevas tecnologías' },
        { icon:'🎯', name:'Enfoque en Calidad', description:'Compromiso con buenas prácticas y código limpio' },
        { icon:'⚡', name:'Adaptabilidad', description:'Flexibilidad para nuevos desafíos y tecnologías' },
        { icon:'⏰', name:'Gestión del Tiempo', description:'Organización y cumplimiento de plazos' },
        { icon:'🌐', name:'Comunicación Técnica', description:'Explicación clara de conceptos técnicos para diferentes públicos y equipos.' },
        { icon:'💡', name:'Resolución de Problemas', description:'Análisis crítico y soluciones creativas' }
      ]
    },

    contact: {
      title: '¿Trabajemos Juntos?',
      subtitle: 'Estoy disponible para oportunidades y proyectos interesantes',
      email: 'Email',
      github: 'GitHub',
      linkedin: 'LinkedIn'
    }
  }
};